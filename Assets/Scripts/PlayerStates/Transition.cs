using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Transition // make struct?
{
    private EntityState parentState;

    [SerializeField] private TransitionEvent Event;
    
    [SerializeField] private EntityState TransitionToState;

    public void Initialize(EntityState parentState) => this.parentState = parentState;

    public void OnActivateState() => Event.RegisterListener(this);

    public void OnDeactivateState() => Event.UnregisterListener(this);

    public void OnEventRaised() => parentState.InvokeTransition(TransitionToState);

}

