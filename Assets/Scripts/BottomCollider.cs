using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BottomCollider : CollisionHandler
{
    public event Action OnPlatformEnter;
    public event Action OnPlatformExit;
    protected override void OnCollisionEvent(CollisionEvent context, int layer)
    {
        if (context == CollisionEvent.Enter)
        {
            OnPlatformEnter?.Invoke();
        }
        else
        {
            OnPlatformExit?.Invoke();
        }

        Debug.Log(context + " " + layer);
    }

}