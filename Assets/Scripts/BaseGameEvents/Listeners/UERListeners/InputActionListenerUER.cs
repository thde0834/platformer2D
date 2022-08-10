using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Game Events/UER Listeners/InputAction")]
public class InputActionListenerUER : BaseGameEventListener<InputAction, InputActionEvent, UnityInputActionEvent> { }
