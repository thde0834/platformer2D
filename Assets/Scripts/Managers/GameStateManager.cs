using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : Manager<GameStateManager>
{
    public GameState currentState { get; private set; }
    private Dictionary<GameStateEnum, GameState> availableStates;

    private GameStateManager() : base()
    {
        InitializeStates();
    }

    private void InitializeStates()
    {
        if (availableStates != null)
        {
            throw new System.Exception("GameStates already set!");
        }

        availableStates = new Dictionary<GameStateEnum, GameState>()
        {
            { GameStateEnum.Play,   new PlayState(this) },
            { GameStateEnum.Paused, new PausedState(this) }
        };
    }

    public void SetCurrentGameState(GameStateEnum enumKey)
    {
        if (availableStates.ContainsKey(enumKey) == false)
        {
            throw new System.Exception("GameState with key: " + enumKey + " does not exist in dictionary!");
        }

        if (currentState?.GameStateEnum == enumKey)
        {
            throw new System.Exception("GameState with GameStateEnum: " + enumKey + " is already active!");
        }

        currentState?.onExit();
        currentState = availableStates[enumKey];
        currentState?.onEnter();
    }

}
