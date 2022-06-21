using System.Collections.Generic;
using UnityEngine;

public abstract class GameEvent<T> : ScriptableObject where T : IEventListener
{
    private List<T> eventListeners;

    private void OnEnable() => eventListeners = new List<T>();

    private void OnDisable() => eventListeners = null;

    public void Raise()
    {
        for (int i = eventListeners.Count - 1; i >= 0; i--)
        {
            eventListeners[i].OnEventRaised();
        }
    }
    public void RegisterListener(T eventListener)
    {
        if (eventListeners.Contains(eventListener) == false)
        {
            eventListeners.Add(eventListener);
        }
    }
    public void UnregisterListener(T eventListener)
    {
        if (eventListeners.Contains(eventListener) == true)
        {
            eventListeners.Remove(eventListener);
        }
    }

}

