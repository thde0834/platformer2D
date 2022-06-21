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
    }

    private void InitializeStateMachine(EntityState[] states)
    {
        stateDictionary = new Dictionary<string, EntityState>();

        foreach(var state in states)
        {
            AddState(state);
        }

        // for now
        if (currentState != null)
        {
            currentState.OnEnter();
        }
        else
        {
            currentState = PlayerStates[1];
            currentState.OnEnter();
        }
    }

    public void SetCurrentState(EntityState state)
    {
        if (currentState?.Equals(state) == true)
        {
            throw new System.Exception($"{gameObject} [this] CurrentState: {currentState} is already set to {state}!");
            //Debug.Log($"{gameObject} [this] CurrentState: {currentState} is already set to {state}!");

        }

        currentState.OnExit();
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

        state.InitializeState(this);
        stateDictionary.Add(stateType, state);
    }
}
