using UnityEngine;
using System.Collections.Generic;
using System;

public class InputManager : Manager<InputManager>
{
    private PlayerControls playerControls;
    private static PlayerControls.ControlsActions controlsActions;

    private static InputMap CurrentInputMap;

    public override void Awake()
    {
        base.Awake();
        playerControls = InitializePlayerControls(playerControls);
    }

    private PlayerControls InitializePlayerControls(PlayerControls playerControls)
    {
        if (playerControls != null)
        {
            throw new System.Exception("PlayerControls already set!");
        }

        playerControls = new PlayerControls();
        playerControls.Enable();
        controlsActions = playerControls.Controls;

        return playerControls;
    }

    public static void SetInputMap(InputMap inputMap)
    {
        var enumKey = inputMap.GameStateEnum;
        if (CurrentInputMap?.GameStateEnum == enumKey)
        {
            throw new System.Exception($"InputMap with GameStateEnum: {enumKey} already set!");
        }

        CurrentInputMap?.Disable();
        CurrentInputMap = inputMap;
        controlsActions.SetCallbacks(CurrentInputMap);
        CurrentInputMap.Enable();
    }

}
