using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allow player to move
public class PlayState : GameState
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Play;

    public PlayState(GameStateManager gameStateManager) : base(gameStateManager)
    {

    }

}
