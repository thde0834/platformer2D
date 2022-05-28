using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputMap
{
    protected PlayerControls playerControls;
    protected Dictionary<InputMapEnum, Action> inputMapActions;
    public InputMap(PlayerControls playerControls)
    {
        this.playerControls = playerControls;
        inputMapActions = InitializeInputMapActions();
    }

    protected abstract Dictionary<InputMapEnum, Action> InitializeInputMapActions();
}
