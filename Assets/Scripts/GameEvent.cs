using System.Collections.Generic;
using UnityEngine;

public class GameEvent : ScriptableObject
{
    private List<GameEventListener> gameEventListeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = gameEventListeners.Count - 1; i >= 0; i--)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }
    public void RegisterListener(GameEventListener gameEventListener)
    {
        if (gameEventListeners.Contains(gameEventListener) == false)
        {
            gameEventListeners.Add(gameEventListener);
        }
    }
    public void UnregisterListener(GameEventListener gameEventListener)
    {
        if (gameEventListeners.Contains(gameEventListener) == true)
        {
            gameEventListeners.Remove(gameEventListener);
        }
    }

}
