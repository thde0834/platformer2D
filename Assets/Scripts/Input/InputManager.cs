using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Input/Input Manager")]
public class InputManager : ScriptableObject
{
    private GameInput gameInput;
    private ActionMapController activeMapController;

    [SerializeField] private List<ActionMapController> actionMapControllers;
    private Dictionary<Type, ActionMapController> controllerDictionary;

    private void OnEnable()
    {
        gameInput = new GameInput();

        controllerDictionary = new Dictionary<Type, ActionMapController>();
        actionMapControllers.ForEach((actionMap) =>
        {
            actionMap.InitializeController(gameInput);
            controllerDictionary.Add(actionMap.GetType(), actionMap);
        });

        // for now -- will create script that initializes game (set input, player state, etc.) later on (maybe idk)
        activeMapController = SetInitialMapController(typeof(GameplayController));
    }

    private ActionMapController SetInitialMapController(Type type)
    {
        var initialController = controllerDictionary[type];
        initialController.Enable();

        return initialController;
    }

    public void SetActiveMapController(Type type)
    {
        activeMapController.Disable();
        activeMapController = controllerDictionary[type];
        activeMapController.Enable();
    }

}
