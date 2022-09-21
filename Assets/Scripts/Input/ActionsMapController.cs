using System;
using UnityEngine;

public abstract class ActionsMapController : ScriptableObject
{
    public abstract void Initialize(GameInput gameInput);
    public abstract void Enable();
    public abstract void Disable();
}