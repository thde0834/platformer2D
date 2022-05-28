using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// pause game time along with player
// allow control of pause menu UI
public class PausedState : GameState
{
    public PausedState(InputManager inputManager) : base(inputManager)
    {

    }

    protected override void InitializeGameState()
    {
        gameStateEnum = GameStateEnum.Paused;
    }

    // set IM
    public override void onEnter()
    {
        inputManager.SetActiveInputMap(gameStateEnum);
    }

    // unset IM
    public override void onExit()
    {
        
    }
}
