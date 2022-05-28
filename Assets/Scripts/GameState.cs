using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    protected InputManager inputManager;
    protected GameStateEnum gameStateEnum;

    public GameState(InputManager inputManager)
    {
        this.inputManager = inputManager;
        InitializeGameState();
    }

    protected abstract void InitializeGameState();

    public virtual void onEnter() { }

    public virtual void onExit() { }

}
