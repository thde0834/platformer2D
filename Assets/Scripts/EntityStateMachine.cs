using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public abstract class EntityStateMachine : MonoBehaviour
{
    [SerializeField] private EntityController ParentEntityController;

    [field: SerializeField] public EntityState CurrentState { get; private set; }
    private Dictionary<EntityStateEnum, EntityState> entityStates;

    public void InitializeStateMachine(EntityController entityController, EntityState[] entityStates)
    {
        ParentEntityController = entityController;
        this.entityStates = new Dictionary<EntityStateEnum, EntityState>();
        foreach (var entityState in entityStates)
        {
            AddState(entityState);
        }
        SetCurrentState(this.entityStates.First().Key); // fix later
    }

    public void SetCurrentState(EntityStateEnum stateKey)
    {
        CurrentState?.OnExit();
        CurrentState = entityStates[stateKey];
        CurrentState.OnEnter();
    }

    public void AddState(EntityState entityState)
    {
        var stateKey = entityState.EntityStateEnum;
        if (entityStates.ContainsKey(stateKey))
        {
            throw new System.Exception($"entityStateMachine already has a State with Key: {stateKey}!");
        }
        entityStates.Add(stateKey, entityState);
        entityState.SetParentEntityController(ParentEntityController);
    }

}


