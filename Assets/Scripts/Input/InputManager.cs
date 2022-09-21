using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Input/Input Manager")]
public class InputManager : ScriptableObject
{
    private GameInput gameInput;
    private ActionsMapController activeMapController;

    [SerializeField] private List<ActionsMapController> actionMapControllers = new List<ActionsMapController>();

    public ActionsMapController GetController(System.Type type) => actionMapControllers.Find(c => c.GetType() == type);

    private void OnEnable()
    {
        gameInput = new GameInput();

        actionMapControllers.ForEach(c => c.Initialize(gameInput));

        // for now -- will create script that initializes game (set input, player state, etc.) later on (maybe idk)
        activeMapController = SetInitialMapController(typeof(GameplayController));
    }

    private ActionsMapController SetInitialMapController(Type type)
    {
        var initialController = GetController(type);
        initialController.Enable();

        return initialController;
    }

    public void SetActiveMapController(Type type)
    {
        activeMapController.Disable();
        activeMapController = GetController(type);
        activeMapController.Enable();
    }

}
