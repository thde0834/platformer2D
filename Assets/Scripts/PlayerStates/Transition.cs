using UnityEngine;

[System.Serializable]
public class Transition : IEventListener
{
    private EntityState parentEntityState;

    [SerializeField] private TransitionEvent Event;

    [SerializeField] private EntityState TransitionToState;

    public void InitializeTransition(EntityState parentState) => this.parentEntityState = parentState;

    public void OnActivateState() => Event.RegisterListener(this);

    public void OnDeactivateState() => Event.UnregisterListener(this);

    public void OnEventRaised() => parentEntityState.InvokeTransition(TransitionToState);

}
