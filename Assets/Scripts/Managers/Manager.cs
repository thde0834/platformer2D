using System;
using UnityEngine;

public abstract class Manager<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    public virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this as T;
    }

}