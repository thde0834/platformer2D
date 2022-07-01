using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Input/Input Manager")]
public class InputManager : ScriptableObject
{
    private GameInput gameInput;
    private ActionMapController activeMapController;

    [SerializeField] private ActionMapController[] actionMapControllers;
    private Dictionary<Type, ActionMapController> controllerDictionary;

    private void OnEnable()
    {
        gameInput = new GameInput();

        controllerDictionary = new Dictionary<Type, ActionMapController>();
        foreach(var actionMap in actionMapControllers)
        {
            actionMap.InitializeController(gameInput);
            controllerDictionary.Add(actionMap.GetType(), actionMap);
        }

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
