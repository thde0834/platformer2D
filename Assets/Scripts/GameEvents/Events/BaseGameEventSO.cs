using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BaseGameEventSO : ScriptableObject
{
    public abstract void Raise(object input);
}

public abstract class BaseGameEventSO<T> : BaseGameEventSO
{
    private readonly List<BaseGameEventListenerSO<T>> eventListeners = new List<BaseGameEventListenerSO<T>>();
    
    public override void Raise(object input) { Raise((T)input); }
    public void Raise(T item)
    {
        for(int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(item);
        }
    }

    public void RegisterListener(BaseGameEventListenerSO<T> listener)
    {
        if (!eventListeners.Contains(listener))
        {
            eventListeners.Add(listener);
        }
    }

    public void UnregisterListener(BaseGameEventListenerSO<T> listener)
    {
        if (eventListeners.Contains(listener))
        {
            eventListeners.Remove(listener);
        }
    }
}
