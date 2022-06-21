using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class EntityState : ScriptableObject
{
    [SerializeField] 
    private Transition[] Transitions;
    private List<Transition> transitionList;

    [SerializeField]
    private EntityAction[] EntityActions;
    private List<EntityAction> entityActionList;

    private StateMachine parentStateMachine;

    private void OnEnable()
    {
        transitionList = new List<Transition>();
        
        foreach (var transition in Transitions)
        {
            transition.InitializeTransition(this);
            transitionList.Add(transition);
        }

        entityActionList = new List<EntityAction>();

        if (EntityActions != null)
        {
            foreach (var entityAction in EntityActions)
            {
                entityAction.InitializeAction(this);
                entityActionList.Add(entityAction);
            }
        }
        
    }

    private void OnDisable()
    {
        transitionList = null;
        entityActionList = null;
    }

    public void InitializeState(StateMachine stateMachine) => parentStateMachine = stateMachine;
    
    public void OnEnter()
    {
        foreach (var transition in transitionList)
        {
            transition.OnActivateState();
        }
    }

    public void OnExit()
    {
        foreach (var transition in transitionList)
        {
            transition.OnDeactivateState();
        }
    }

    public void InvokeTransition(EntityState nextState)
    {
        parentStateMachine.SetCurrentState(nextState);
    }
}

