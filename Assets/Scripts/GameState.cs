using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    public abstract GameStateEnum GameStateEnum { get; }

    public GameState(GameStateManager gameStateManager)
    {

    }

    public virtual void onEnter() 
    { 
        InputManager.getInstance.SetActiveInputMap(GameStateEnum);
    }

    public virtual void onExit() { }

}
