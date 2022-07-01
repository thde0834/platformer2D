using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class EntityState : ScriptableObject
{
    private EntityStateMachine parentStateMachine;
    
    public VoidListener[] transitionListeners;

    public void Initialize(EntityStateMachine stateMachine) => parentStateMachine = stateMachine; 

    public void ActivateState() => parentStateMachine.SetCurrentState(this);
}