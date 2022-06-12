using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum PlayerStateEnum
{
    Grounded, Aerial,
    GroundedCasting, AerialCasting
}

// when creating, must match concrete PlayerState class name
[CreateAssetMenu(fileName = "EntityStateData", menuName = "ScriptableObjects/EntityStateData")]
public class EntityStateData : ScriptableObject
{
    public int health = 69; // how do i do dis lol
}

// to do : create playerstate scriptable objects
[Serializable]
public abstract class PlayerState
{
    public abstract PlayerStateEnum PlayerStateEnum { get; }
    public PlayerState()
    {

    }

    public virtual void onEnter() { }
    public virtual void onExit() { }

}

public class Grounded : PlayerState
{
    public override PlayerStateEnum PlayerStateEnum => PlayerStateEnum.Grounded;

    public Grounded() : base()
    {

    }

}

public class Aerial : PlayerState
{
    public override PlayerStateEnum PlayerStateEnum => PlayerStateEnum.Aerial;

    public Aerial() : base()
    {

    }

}

[Serializable]
public class PlayerStateMachine : MonoBehaviour
{
    private Dictionary<PlayerStateEnum, PlayerState> playerStates;
    [field: SerializeReference] public PlayerState CurrentPlayerState { get; private set; }

    public void SetStates(Dictionary<PlayerStateEnum, PlayerState> playerStates)
    {
        this.playerStates = playerStates;
    }

    public void SetCurrentPlayerState(PlayerStateEnum enumKey)
    {
        if (playerStates.ContainsKey(enumKey) == false)
        {
            throw new System.Exception("PlayerState with key: " + enumKey + " does not exist in dictionary!");
        }

        if (CurrentPlayerState?.PlayerStateEnum == enumKey)
        {
            throw new System.Exception("PlayerState with GameStateEnum: " + enumKey + " is already active!");
        }

        CurrentPlayerState?.onExit();
        CurrentPlayerState = playerStates[enumKey];
        CurrentPlayerState?.onEnter();
    }

}
