using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// pause game time along with player
// allow control of pause menu UI
public class PausedState : GameState
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Paused;
    protected override InputMap InputMap => new PausedInputMap();

}
