
using System.Collections.Generic;

public class InputManager : Manager<InputManager>
{
    private PlayerControls playerControls;
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
        playerControls.Keyboard.Enable();
    }

    private void InitializeInputMaps()
    {
        inputMaps = new Dictionary<GameStateEnum, InputMap>()
        {
            { GameStateEnum.Play,   new PlayInputMap(playerControls) },
            { GameStateEnum.Paused, null },
        };
    }

    public void SetActiveInputMap(GameStateEnum enumKey)
    {
        if (!inputMaps.ContainsKey(enumKey))
        {
            throw new System.Exception("Input Map with key: " + enumKey + " does not exist in dictionary!");
        }

        activeInputMap = inputMaps[enumKey];
    }
}
