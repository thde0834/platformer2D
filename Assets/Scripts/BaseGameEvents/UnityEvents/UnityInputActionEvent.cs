using UnityEngine.Events;
using UnityEngine.InputSystem;

/*
 *  UnityInputActionEvent:
 *      - A UnityEvent class that passes a InputAction parameter to some object.
 *      - Exists because we can't just use UnityEvent<InputAction> in code for some reason.
 */

[System.Serializable]
public class UnityInputActionEvent : UnityEvent<InputAction> { }
