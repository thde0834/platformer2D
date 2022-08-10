using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BaseGameEvent : ScriptableObject
{
    public abstract void Raise(object input);

    public abstract void RegisterListener(object listener);
    public abstract void UnregisterListener(object listener);
}

public abstract class BaseGameEvent<T> : BaseGameEvent
{
    private List<BaseGameEventListener<T>> eventListeners = new List<BaseGameEventListener<T>>();

    public sealed override void Raise(object input) => Raise((T)input);
    public void Raise(T item)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(item);
        }
    }

    public sealed override void RegisterListener(object listener) => RegisterListener((BaseGameEventListener<T>)listener);
    public void RegisterListener(BaseGameEventListener<T> listener)
    {
        if (!eventListeners.Contains(listener))
        {
            eventListeners.Add(listener);
        }
    }

    public sealed override void UnregisterListener(object listener) => UnregisterListener((BaseGameEventListener<T>)listener);
    public void UnregisterListener(BaseGameEventListener<T> listener)
    {
        if (eventListeners.Contains(listener))
        {
            eventListeners.Remove(listener);
        }
    }
}