using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PausedInputMap : InputMap
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Paused;

    public PausedInputMap(InputManager inputManager) : base(inputManager)
    {
        
    }

    protected override List<Action> InitializeUnsubscribeList()
    {
        var list = new List<Action>()
        {
            // Up
            { new Action(() => playerControls.Up.started -= OnUp) },
            // Down
            { new Action(() => playerControls.Down.started -= OnDown) },
            // Left
            { new Action(() => playerControls.Left.started -= OnLeft) },
            // Right
            { new Action(() => playerControls.Right.started -= OnRight) },
            // Jump
            { new Action(() => playerControls.Jump.started -= OnJump) },
            { new Action(() => playerControls.Jump.performed -= OnJump) },
            { new Action(() => playerControls.Jump.canceled -= OnJump) },
            // Spell
            { new Action(() => playerControls.Spell.started -= OnSpell) },
            { new Action(() => playerControls.Spell.performed -= OnSpell) },
            { new Action(() => playerControls.Spell.canceled -= OnSpell) },
            // Escape
            { new Action(() => playerControls.Escape.performed -= OnEscape) },
            { new Action(() => playerControls.Escape.canceled -= OnEscape) },
            // Interact
            { new Action(() => playerControls.Interact.performed -= OnInteract) },
            { new Action(() => playerControls.Interact.canceled -= OnInteract) },
            // Cancel
            { new Action(() => playerControls.Cancel.performed -= OnCancel) },
            { new Action(() => playerControls.Cancel.canceled -= OnCancel) },
        };

        return list;
    }

    public override void Enable()
    {
        base.Enable();
        UnsubscribeActions(unsubscribeList);
    }

    public override void Disable()
    {
        base.Disable();
    }

    public override void OnUp(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

    public override void OnDown(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

    public override void OnLeft(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

    public override void OnRight(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

    public override void OnEscape(InputAction.CallbackContext context)
    {
        GameStateManager.getInstance.SetCurrentGameState(GameStateEnum.Play);
    }

    public override void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

    public override void OnCancel(InputAction.CallbackContext context)
    {
        Debug.Log("Paused " + context);
    }

}
