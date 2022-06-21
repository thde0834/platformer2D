using UnityEngine;
using UnityEngine.Serialization;

[System.Serializable]
public class EntityAction : IEventListener
{
    private EntityState parentEntityState;

    [SerializeField]
    private EntityActionEvent Event;

    public void InitializeAction(EntityState parentEntityState) => this.parentEntityState = parentEntityState;

    public void OnEventRaised() => throw new System.NotImplementedException();

}
