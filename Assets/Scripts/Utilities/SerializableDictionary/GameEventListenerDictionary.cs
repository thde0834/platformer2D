using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Utilities/SerializableDictionary/GameEvent-Listener")]
public class GameEventListenerDictionary : SerializableDictionary<BaseTriggerEvent, List<BaseGameEventListener>> 
{
    public void RegisterAllListeners()
    {
        foreach(var item in base.Keys)
        {
            this[item].ForEach((listener) => item.RegisterListener(listener));
        }
    }

    public void UnregisterAllListeners()
    {
        foreach (var item in base.Keys)
        {
            this[item].ForEach((listener) => item.UnregisterListener(listener));
        }
    }

}