using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BaseState : ScriptableObject
{
    [field: SerializeField] public List<Transition> Transitions { get; private set; } = new List<Transition>();
    private StateMachine parentStateMachine;

    public void SetParentStateMachine(StateMachine parent) => parentStateMachine = parent;

    public BaseState Clone()
    {
        BaseState state = Instantiate(this);
        state.Transitions.ConvertAll(t => t.Clone());
        return state;
    }

    public void ActivateState() => parentStateMachine.SetCurrentState(this);

    // ONLY to be Called by StateMachine.cs
    public virtual void OnEnter() => Transitions.ForEach(transition => transition.RegisterSelf());
    public virtual void OnExit() => Transitions.ForEach(transition => transition.UnregisterSelf());
}
