using System;
using System.Collections.Generic;
using UnityEngine;

public class PausedInputMap : InputMap
{
    public PausedInputMap(PlayerControls playerControls) : base(playerControls)
    {
        
    }

    protected override Dictionary<InputMapEnum, Action> InitializeInputMapActions()
    {
        var initialActions = new Dictionary<InputMapEnum, Action>()
        {
            { InputMapEnum.Up,      null },
            { InputMapEnum.Down,    null },
            { InputMapEnum.Left,    null },
            { InputMapEnum.Right,   null },
        };

        return initialActions;
    }
}
