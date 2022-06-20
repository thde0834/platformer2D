using System;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private EntityState[] PlayerStates;
    private Dictionary<string, EntityState> stateDictionary;

    [SerializeField] private EntityState currentState;

    private void Awake()
    {
        InitializeStateMachine(PlayerStates);

        // for now
        if (currentState != null)
        {
            SetCurrentState(currentState);
        }
        else
        {
            SetCurrentState(PlayerStates[1]);
        }
    }

    private void InitializeStateMachine(EntityState[] states)
    {
        stateDictionary = new Dictionary<string, EntityState>();

        foreach(var state in states)
        {
            AddState(state);
        }
    }

    public void SetCurrentState(EntityState state)
    {
        if (currentState?.Equals(state) == true)
        {
            throw new System.Exception($"{gameObject} [this] CurrentState: {currentState} is already set to {state}!");
        }

        currentState?.OnExit();
        currentState = stateDictionary[state.ToString()];
        currentState.OnEnter();
    }

    public void AddState(EntityState state)
    {
        var stateType = state.ToString();
        if (stateDictionary.ContainsKey(stateType))
        {
            throw new System.Exception($"{gameObject} [{this}] State with Type: {stateType} already exists in the StateMachine!");
        }

        state.Initialize(this);
        stateDictionary.Add(stateType, state);
    }
}
