using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Gameplay Controller", menuName = "Input/Controllers/Gameplay Controller")]
public class GameplayController : ActionMapController, GameInput.IGameplayActions
{
    private GameInput.GameplayActions gameplayActions;

    public override void InitializeController(GameInput gameInput)
    {
        gameplayActions = gameInput.Gameplay;
        gameplayActions.SetCallbacks(this);
    }


    // use custom events 
    [Space]
    public UnityFloatEvent LookEvent = new UnityFloatEvent();
    public UnityFloatEvent MoveEvent = new UnityFloatEvent();
    public UnityEvent DashEvent = new UnityEvent();
    public UnityEvent JumpEvent = new UnityEvent();
    public UnityEvent AttackEvent = new UnityEvent();
    public UnityEvent MapEvent = new UnityEvent();
    public UnityEvent PauseEvent = new UnityEvent();
    public UnityEvent CastEvent = new UnityEvent();


    public override void Enable() => gameplayActions.Enable();
    public override void Disable() => gameplayActions.Disable();

    public void OnLook(InputAction.CallbackContext context) => LookEvent.Invoke(context.ReadValue<float>());

    public void OnMove(InputAction.CallbackContext context) => MoveEvent.Invoke(context.ReadValue<float>());

    public void OnDash(InputAction.CallbackContext context) => DashEvent.Invoke();

    public void OnJump(InputAction.CallbackContext context) => JumpEvent.Invoke();

    public void OnAttack(InputAction.CallbackContext context) => AttackEvent.Invoke();

    public void OnMap(InputAction.CallbackContext context) => MapEvent.Invoke();

    public void OnPause(InputAction.CallbackContext context) => PauseEvent.Invoke();

    public void OnCast(InputAction.CallbackContext context) => CastEvent.Invoke();

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
