using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Gameplay Controller", menuName = "Input/Controllers/Gameplay")]
public class GameplayController : ActionMapController, GameInput.IGameplayActions
{
    private GameInput.GameplayActions gameplayActions;

    public override void InitializeController(GameInput gameInput)
    {
        gameplayActions = gameInput.Gameplay;
        gameplayActions.SetCallbacks(this);
    }


    //[field: Space] // spacing in inspector window
    [Header("Gameplay Input Events")]
    [field: SerializeField] private InputActionEventDictionary LookEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary MoveEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary DashEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary JumpEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary AttackEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary MapEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary PauseEvent;
    [Space]
    [field: SerializeField] private InputActionEventDictionary CastEvent;

    public override void Enable() => gameplayActions.Enable();
    public override void Disable() => gameplayActions.Disable();

    public void OnLook(InputAction.CallbackContext context) => LookEvent[context.phase].Invoke(context.action);

    public void OnMove(InputAction.CallbackContext context) => MoveEvent[context.phase]?.Invoke(context.action);

    public void OnDash(InputAction.CallbackContext context) => DashEvent[context.phase].Invoke(context.action);

    public void OnJump(InputAction.CallbackContext context) => JumpEvent[context.phase].Invoke(context.action);

    public void OnAttack(InputAction.CallbackContext context) => AttackEvent[context.phase].Invoke(context.action);

    public void OnMap(InputAction.CallbackContext context) => MapEvent[context.phase].Invoke(context.action);

    public void OnPause(InputAction.CallbackContext context) => PauseEvent[context.phase].Invoke(context.action);

    public void OnCast(InputAction.CallbackContext context) => CastEvent[context.phase].Invoke(context.action);

    public void OnSpellUp(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnSpellDown(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnSpellLeft(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnSpellRight(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

}
