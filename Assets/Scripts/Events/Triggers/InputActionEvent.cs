using UnityEngine;
using UnityEngine.InputSystem;

/*
 *  InputActionEvent:
 *      - A BaseGameEvent class that raises BaseGameEventListener objects 
 *      and passes a InputAction paramater
 */

[CreateAssetMenu(menuName = "Game Events/Triggers/InputAction")]
public class InputActionEvent : BaseTriggerEvent<InputAction> { }
