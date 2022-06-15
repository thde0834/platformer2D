using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityStateEnum
{
    Grounded, Aerial
}

public abstract class EntityState : ScriptableObject
{
    public abstract EntityStateEnum EntityStateEnum { get; }
    public EntityAction[] EntityActions;

    private EntityController ParentEntityController;

    public void SetParentEntityController(EntityController ParentEntityController)
    {
        this.ParentEntityController = ParentEntityController;
    }

    public abstract void OnEnable();
    public abstract void OnDisable();

    public virtual void OnEnter() { }
    public virtual void OnExit() { }
}
