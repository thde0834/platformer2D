using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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
    public void RegisterListner(GameEventListener gameEventListener)
    {
        gameEventListeners.Add(gameEventListener);
    }
    public void UnregisterListner(GameEventListener gameEventListener)
    {
        gameEventListeners.Remove(gameEventListener);
    }

}
