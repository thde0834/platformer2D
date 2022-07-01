using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Events/Listeners/EntityState Listener")]
public class EntityStateListener : BaseGameEventListener<EntityState, EntityStateEvent, UnityEntityStateEvent> { }
