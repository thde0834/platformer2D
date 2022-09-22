using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State/State Machine")]
public class StateMachine : ScriptableObject
{
    [field: SerializeField] public BaseState CurrentState { get; private set; }
    [SerializeField] private List<BaseState> States = new List<BaseState>();

    public BaseState GetState(System.Type type) => States.Find(state => state.GetType() == type);

    private void OnEnable() => States.ForEach(state => state.SetParentStateMachine(this));

    // To avoid two StateMachines working on the same StateMachine SO
    // Called in Start()
    public StateMachine Clone()
    {
        StateMachine sm = Instantiate(this);
        sm.States.ConvertAll(state => state.Clone());
        return sm;
    }

    public void SetCurrentState(BaseState state)
    {
        CurrentState?.OnExit();
        CurrentState = GetState(state.GetType());
        CurrentState.OnEnter();
    }

    public void AddState(BaseState state)
    {
        if (GetState(state.GetType()) == default)
        {
            States.Add(state);
        }
    }

    public void RemoveState(BaseState state)
    {
        if (GetState(state.GetType()) != default)
        {
            States.Remove(state);
        }
    }
}