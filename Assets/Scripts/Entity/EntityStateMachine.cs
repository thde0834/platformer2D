using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Entity/StateMachine")]
public class EntityStateMachine : ScriptableObject
{
    [SerializeField]
    private List<EntityState> playerStates;

    private Dictionary<Type, EntityState> stateDictionary;

    [field: SerializeField] public EntityState CurrentState { get; private set; }

    private void OnEnable()
    {
        stateDictionary = new Dictionary<Type, EntityState>();

        foreach (var state in playerStates)
        {
            AddState(state);
        }

        // for now
        CurrentState = stateDictionary[typeof(AerialState)];
    }

    private void OnDisable()
    {
        stateDictionary = null;
        CurrentState = null;    // temporary
    }

    public void SetCurrentState(EntityState state)
    {
        var stateType = state.GetType();

        if (CurrentState.GetType() == stateType)
        {
            throw new System.Exception($"[{this}] Cannot set CurrentState: {CurrentState} to State: {state} as they have the same Type: {stateType}!");
        }

        //CurrentState.OnExit();
        CurrentState = stateDictionary[stateType];
        //CurrentState.OnEnter();
    }

    public void AddState(EntityState state)
    {
        var stateType = state.GetType();
        if (stateDictionary.ContainsKey(stateType))
        {
            throw new System.Exception($"[{this}] State with Type: {stateType} already exists in the StateMachine!");
        }

        state.Initialize(this);
        stateDictionary.Add(stateType, state);
    }
}
