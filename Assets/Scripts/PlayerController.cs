using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerController : MonoBehaviour
{
    // Handles Player Movement
    [SerializeField] private PlayerStateMachine PlayerStateMachine;
    public static Rigidbody2D Rigidbody { get; private set; }
    public static PlayerController Instance { get; private set; }

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        InitializeController();
    }

    private void InitializeController()
    {
        PlayerStateMachine = InitializePlayerStateMachine(GetComponent<PlayerStateMachine>());
        Rigidbody = InitializeRigidbody(GetComponent<Rigidbody2D>());
    }

    #region Initializers

    private PlayerStateMachine InitializePlayerStateMachine(PlayerStateMachine playerStateMachine)
    {
        if (playerStateMachine == null)
        {
            throw new System.Exception("Component: PlayerStateMachine is not attached to Player!");
        }

        playerStateMachine.SetStates(new Dictionary<PlayerStateEnum, PlayerState>()
        {
            { PlayerStateEnum.Grounded, new Grounded() },
            { PlayerStateEnum.Aerial, new Aerial() }
        });

        return playerStateMachine;
    }

    private Rigidbody2D InitializeRigidbody(Rigidbody2D rigidbody2D)
    {
        if (rigidbody2D == null)
        {
            throw new System.Exception("Component: PlayerStateMachine is not attached to Player!");
        }

        return rigidbody2D;
    }

    #endregion

}
