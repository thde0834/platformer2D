using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Entity/Actions/Action")]
public class EntityAction : ScriptableObject
{
    [SerializeField]
    private BaseGameEventSO actionTriggerEvent;

    [SerializeField] 
    private List<BaseGameEventListenerSO> OnStartedListeners;

    [SerializeField] 
    private List<BaseGameEventListenerSO> OnPerformedListeners;

    [SerializeField] 
    private List<BaseGameEventListenerSO> OnCanceledListeners;

    
}
