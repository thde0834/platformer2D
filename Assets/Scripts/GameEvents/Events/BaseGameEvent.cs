using System.Collections.Generic;

[System.Serializable]
public abstract class BaseGameEvent   // Unity doesn't support interfaces in inspector 
{
    public abstract void Raise(object input);
}

public abstract class BaseGameEvent<T> : BaseGameEvent
{
    private readonly List<BaseGameEventListener<T>> eventListeners = new List<BaseGameEventListener<T>>();
    public override void Raise(object input) { Raise((T)input); }

    public void Raise(T item)
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised(item);
        }
    }

    public void RegisterListener(BaseGameEventListener<T> listener)
    {
        if (!eventListeners.Contains(listener))
        {
            eventListeners.Add(listener);
        }
    }

    public void UnregisterListener(BaseGameEventListener<T> listener)
    {
        if (eventListeners.Contains(listener))
        {
            eventListeners.Remove(listener);
        }
    }
}