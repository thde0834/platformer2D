using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allow player to move
public class PlayState : GameState
{
    public PlayState(InputManager inputManager) : base(inputManager)
    {

    }

    protected override void InitializeGameState()
    {
        gameStateEnum = GameStateEnum.Play;
    }

    // set IM
    public override void onEnter()
    {
        inputManager.SetActiveInputMap(gameStateEnum);
    }

    // unset IM -- idk if i need to
    public override void onExit()
    {

    }
}
