using System;
using UnityEngine;

public abstract class ActionMapController : ScriptableObject
{
    public abstract void InitializeController(GameInput gameInput);
    public abstract void Enable();
    public abstract void Disable();
}