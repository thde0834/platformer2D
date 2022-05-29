using UnityEngine;
using System.Collections.Generic;

public class InputManager : Manager<InputManager>
{
    public PlayerControls playerControls { get; private set; }
    private Dictionary<GameStateEnum, InputMap> inputMaps;
    private InputMap activeInputMap;

    private InputManager() : base()
    {
        InitializeControls();
        InitializeInputMaps();
    }

    private void InitializeControls()
    {
        if (playerControls != null)
        {
            throw new System.Exception("Controls already set!");
        }

        playerControls = new PlayerControls();
        playerControls.Enable();
    }

    private void InitializeInputMaps()
    {
        if (inputMaps != null)
        {
            throw new System.Exception("Input Map already set!");
        }
        inputMaps = new Dictionary<GameStateEnum, InputMap>()
        {
            { GameStateEnum.Play,   new PlayInputMap(this) },
            { GameStateEnum.Paused, new PausedInputMap(this) },
        };

        SetActiveInputMap(GameStateEnum.Play);
    }

    public void SetActiveInputMap(GameStateEnum enumKey)
    {
        if (!inputMaps.ContainsKey(enumKey))
        {
            throw new System.Exception("Input Map with key: " + enumKey + " does not exist in dictionary!");
        }

        if (activeInputMap?.gameStateEnum == enumKey)
        {
            throw new System.Exception("InputMap with GameStateEnum: " + enumKey + " is already active!");
        }

        activeInputMap?.onDisable();
        activeInputMap = inputMaps[enumKey];
        activeInputMap?.onEnable();
    }
}
