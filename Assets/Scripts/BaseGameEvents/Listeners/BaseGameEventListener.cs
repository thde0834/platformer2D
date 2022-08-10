using System;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public abstract class BaseGameEventListener : ScriptableObject
{
    public abstract void OnEventRaised(object item);
}

// This class will be extended by Listeners that will:
//  - Manually (by code) be registered/unregisted to GameEvents by another script
//  - Manually (by code) invoke a response to GameEvents by overriding OnEventRaised

public abstract class BaseGameEventListener<T> : BaseGameEventListener
{
    public sealed override void OnEventRaised(object item) => OnEventRaised((T)item);
    public abstract void OnEventRaised(T item);
}

public abstract class BaseGameEventListener<T, E, UER> : BaseGameEventListener<T>
    where E : BaseGameEvent<T> where UER : UnityEvent<T>
{
    [field: SerializeField] public E GameEvent { get; private set; }

    [field: SerializeField] public UER UnityEventResponse { get; private set; }

    private void OnEnable() => GameEvent.RegisterListener(this);

    private void OnDisable() => GameEvent.UnregisterListener(this);

    public sealed override void OnEventRaised(T item) => UnityEventResponse.Invoke(item);
}