using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Gameplay Controller", menuName = "Input/Controllers/Gameplay")]
public class GameplayController : ActionsMapController, GameInput.IGameplayActions
{
    private GameInput.GameplayActions gameplayActions;

    // to be called only once
    public override void Initialize(GameInput gameInput)
    {
        gameplayActions = gameInput.Gameplay;
        gameplayActions.SetCallbacks(this);
    }

    public override void Enable() => gameplayActions.Enable();
    public override void Disable() => gameplayActions.Disable();


    [Header("Gameplay Input Events")]
    [field: Space, SerializeField] private InputActionEventDictionary LookEvent;
    [field: Space, SerializeField] private InputActionEventDictionary MoveEvent;
    [field: Space, SerializeField] private InputActionEventDictionary DashEvent;
    [field: Space, SerializeField] private InputActionEventDictionary JumpEvent;
    [field: Space, SerializeField] private InputActionEventDictionary AttackEvent;
    [field: Space, SerializeField] private InputActionEventDictionary MapEvent;
    [field: Space, SerializeField] private InputActionEventDictionary PauseEvent;
    [field: Space, SerializeField] private InputActionEventDictionary CastEvent;
    [field: Space, SerializeField] private InputActionEventDictionary CastUpEvent;
    [field: Space, SerializeField] private InputActionEventDictionary CastDownEvent;
    [field: Space, SerializeField] private InputActionEventDictionary CastLeftEvent;
    [field: Space, SerializeField] private InputActionEventDictionary CastRightEvent;

    public void OnLook(InputAction.CallbackContext context) => LookEvent[context.phase]?.Invoke(context.action);

    public void OnMove(InputAction.CallbackContext context) => MoveEvent[context.phase]?.Invoke(context.action);

    public void OnDash(InputAction.CallbackContext context) => DashEvent[context.phase]?.Invoke(context.action);

    public void OnJump(InputAction.CallbackContext context) => JumpEvent[context.phase]?.Invoke(context.action);

    public void OnAttack(InputAction.CallbackContext context) => AttackEvent[context.phase]?.Invoke(context.action);

    public void OnMap(InputAction.CallbackContext context) => MapEvent[context.phase]?.Invoke(context.action);

    public void OnPause(InputAction.CallbackContext context) => PauseEvent[context.phase]?.Invoke(context.action);

    public void OnCast(InputAction.CallbackContext context) => CastEvent[context.phase]?.Invoke(context.action);

    public void OnSpellUp(InputAction.CallbackContext context) => CastUpEvent[context.phase]?.Invoke(context.action);

    public void OnSpellDown(InputAction.CallbackContext context) => CastDownEvent[context.phase]?.Invoke(context.action);

    public void OnSpellLeft(InputAction.CallbackContext context) => CastLeftEvent[context.phase]?.Invoke(context.action);

    public void OnSpellRight(InputAction.CallbackContext context) => CastRightEvent[context.phase]?.Invoke(context.action);

}
