using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseGameEventListener<T, E, UER> : ScriptableObject,
    IGameEventListener<T> where E : BaseGameEvent<T> where UER : UnityEvent<T>
{
    [field: SerializeField] public E GameEvent { get; protected set; }

    [field: SerializeField] public UER UnityEventResponse { get; protected set; }

    private void OnEnable()
    {
        GameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        GameEvent.UnregisterListener(this);
    }

    public void OnEventRaised(T item)
    {
        UnityEventResponse.Invoke(item);
    }
}
