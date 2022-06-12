using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    public abstract GameStateEnum GameStateEnum { get; }
    protected abstract InputMap InputMap { get; }
    
    public virtual void onEnter() => InputManager.SetInputMap(InputMap);

    public virtual void onExit() { }

}
