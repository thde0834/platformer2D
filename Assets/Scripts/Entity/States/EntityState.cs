using System.Collections.Generic;
using UnityEngine;

public abstract class EntityState : ScriptableObject
{
    private EntityStateMachine parentStateMachine;
    
    [SerializeField] 
    private List<VoidListenerUER> transitionListeners;

    [SerializeField]
    private List<InputActionListenerUER> entityActions;

    public void Initialize(EntityStateMachine stateMachine) => parentStateMachine = stateMachine; 

    public void ActivateState() => parentStateMachine.SetCurrentState(this);

    public void OnEnter() => throw new System.NotImplementedException(); //entityActions.ForEach((action) => action.Enable());

    public void OnExit() => throw new System.NotImplementedException(); //entityActions.ForEach((action) => action.Disable());

}
