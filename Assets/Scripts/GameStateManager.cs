using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : Manager<GameStateManager>
{
    public GameState currentState { get; private set; }
    private Dictionary<GameStateEnum, GameState> availableStates;
    private InputManager inputManager;

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

        if (inputManager == null)
        {
            inputManager = InputManager.getInstance;
        }

        availableStates = new Dictionary<GameStateEnum, GameState>()
        {
            { GameStateEnum.Play,   new PlayState(inputManager) },
            { GameStateEnum.Paused, new PausedState(inputManager) }
        };
    }

    public void SetGameState(GameStateEnum enumKey)
    {
        if (!availableStates.ContainsKey(enumKey))
        {
            throw new System.Exception("GameState with key: " + enumKey + " does not exist in dictionary!");
        }

        currentState.onExit();
        currentState = availableStates[enumKey];
        currentState.onEnter();
    }

}
