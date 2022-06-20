using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(menuName = "EntityStates/EntityState")]
public class EntityState : ScriptableObject
{
    [SerializeField] private Transition[] Transitions;
    private List<Transition> transitionsList;
    
    private StateMachine parentStateMachine;

    private void OnEnable()
    {
        transitionsList = new List<Transition>();

        if (Transitions?.Count() != 0)
        {
            foreach (var transition in Transitions)
            {
                transitionsList.Add(transition);
            }
        }
    }

    private void OnDisable()
    {
        transitionsList.Clear();
    }

    public void Initialize(StateMachine stateMachine) => parentStateMachine = stateMachine;
    
    public void OnEnter()
    {
        foreach (var transition in Transitions)
        {
            transition.OnActivateState();
        }
    }

    public void OnExit()
    {
        foreach (var transition in Transitions)
        {
            transition.OnDeactivateState();
        }
    }

    public void InvokeTransition(EntityState nextState)
    {
        parentStateMachine.SetCurrentState(nextState);
    }
}

