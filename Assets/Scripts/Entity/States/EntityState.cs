using System.Collections.Generic;
using UnityEngine;

public abstract class EntityState : ScriptableObject
{
    private EntityStateMachine parentStateMachine;
    
    [SerializeField] 
    private List<VoidListener> transitionListeners;

    [SerializeField]
    private List<EntityAction> entityActions;

    public void Initialize(EntityStateMachine stateMachine) => parentStateMachine = stateMachine; 

    public void ActivateState() => parentStateMachine.SetCurrentState(this);

}
