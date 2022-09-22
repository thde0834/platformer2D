using Libraries;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Gameplay Controller", menuName = "Input/Controllers/Gameplay")]
public class GameplayController : ActionsMapController, GameInput.IGameplayActions
{
    private GameInput.GameplayActions gameplayActions;

    //to be called only once
    public override void Initialize(GameInput gameInput)
    {
        gameplayActions = gameInput.Gameplay;
        gameplayActions.SetCallbacks(this);
    }

    public override void Enable() => gameplayActions.Enable();
    public override void Disable() => gameplayActions.Disable();

    [field: SerializeField]
    private SerializableDictionary<InputActionPhase, InputActionEvent> LookEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> MoveEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> DashEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> JumpEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> AttackEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField]
    private SerializableDictionary<InputActionPhase, InputActionEvent> MapEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> PauseEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> CastEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> CastUpEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField]
    private SerializableDictionary<InputActionPhase, InputActionEvent> CastDownEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> CastLeftEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();
    [field: Space, SerializeField] 
    private SerializableDictionary<InputActionPhase, InputActionEvent> CastRightEvent = new SerializableDictionary<InputActionPhase, InputActionEvent>();

    public void OnLook(InputAction.CallbackContext context) => LookEvent[context.phase]?.Raise(context.action);

    public void OnMove(InputAction.CallbackContext context) => MoveEvent[context.phase]?.Raise(context.action);

    public void OnDash(InputAction.CallbackContext context) => DashEvent[context.phase]?.Raise(context.action);

    public void OnJump(InputAction.CallbackContext context) => JumpEvent[context.phase]?.Raise(context.action);

    public void OnAttack(InputAction.CallbackContext context) => AttackEvent[context.phase]?.Raise(context.action);

    public void OnMap(InputAction.CallbackContext context) => MapEvent[context.phase]?.Raise(context.action);

    public void OnPause(InputAction.CallbackContext context) => PauseEvent[context.phase]?.Raise(context.action);

    public void OnCast(InputAction.CallbackContext context) => CastEvent[context.phase]?.Raise(context.action);

    public void OnSpellUp(InputAction.CallbackContext context) => CastUpEvent[context.phase]?.Raise(context.action);

    public void OnSpellDown(InputAction.CallbackContext context) => CastDownEvent[context.phase]?.Raise(context.action);

    public void OnSpellLeft(InputAction.CallbackContext context) => CastLeftEvent[context.phase]?.Raise(context.action);

    public void OnSpellRight(InputAction.CallbackContext context) => CastRightEvent[context.phase]?.Raise(context.action);

}
