using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allow player to move
public class PlayState : GameState
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Play;
    protected override InputMap InputMap => new PlayInputMap();

}
