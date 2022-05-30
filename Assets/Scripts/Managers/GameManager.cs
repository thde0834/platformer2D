using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameStateManager gameStateManager;
    public InputManager inputManager;

    public void Awake()
    {
        gameStateManager = GameStateManager.getInstance;
        inputManager = InputManager.getInstance;
    }

}
