using UnityEngine;
using UnityEngine.Events;

// This class shouldn't be extended
public abstract class BaseGameEventListener : ScriptableObject
{
    public abstract void RegisterSelf();
    public abstract void UnregisterSelf();

    private void OnEnable() => RegisterSelf();
    private void OnDisable() => UnregisterSelf();

    public abstract void OnEventRaised(object item);
}

// This class shouldn't be extended, only referenced
// e.g. BaseTriggerEvent.cs
public abstract class BaseGameEventListener<T> : BaseGameEventListener
{
    public sealed override void OnEventRaised(object item) => OnEventRaised((T)item);
    public abstract void OnEventRaised(T item);
}

// This class will be extended by Listeners that:
//  - Is passed in a TriggerEvent 
//  - Manually (by code) invoke a response to GameEvents by overriding OnEventRaised
public abstract class BaseGameEventListener<T, E> : BaseGameEventListener<T>
    where E : BaseTriggerEvent<T>
{
    [field: SerializeField] public E TriggerEvent { get; private set; }

    public override void RegisterSelf() => TriggerEvent.RegisterListener(this);
    public override void UnregisterSelf() => TriggerEvent.UnregisterListener(this);
}

public abstract class BaseGameEventListener<T, E, UER> : BaseGameEventListener<T>
    where E : BaseTriggerEvent<T> where UER : UnityEvent<T>
{
    [field: SerializeField] public E TriggerEvent { get; private set; }

    [field: SerializeField] public UER UnityEventResponse { get; private set; }

    public override void RegisterSelf() => TriggerEvent.RegisterListener(this);
    public override void UnregisterSelf() => TriggerEvent.UnregisterListener(this);

    public sealed override void OnEventRaised(T item) => UnityEventResponse.Invoke(item);
}