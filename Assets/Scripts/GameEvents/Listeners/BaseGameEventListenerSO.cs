using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public abstract class BaseGameEventListenerSO : ScriptableObject
{
    public abstract void OnEventRaised(object item);
}

public abstract class BaseGameEventListenerSO<T> : BaseGameEventListenerSO
{
    public override void OnEventRaised(object item) => OnEventRaised((T) item);
    public abstract void OnEventRaised(T item);
}

public abstract class BaseGameEventListenerSO<T, E, UER> : BaseGameEventListenerSO<T> 
    where E : BaseGameEventSO<T> where UER : UnityEvent<T>
{
    [field: SerializeField] public E GameEvent { get; private set; }

    [field: SerializeField] public UER UnityEventResponse { get; private set; }

    private void OnEnable()
    {
        GameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        GameEvent.UnregisterListener(this);
    }

    public override void OnEventRaised(T item)
    {
        UnityEventResponse.Invoke(item);
    }
}
