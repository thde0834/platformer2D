using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayInputMap : InputMap
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Play;

    public PlayInputMap(InputManager inputManager) : base(inputManager)
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
            // Spell
            { new Action(() => playerControls.Spell.started -= OnSpell) },
            // Escape
            { new Action(() => playerControls.Escape.performed -= OnEscape) },
            { new Action(() => playerControls.Escape.canceled -= OnEscape) },
            // Interact
            { new Action(() => playerControls.Interact.started -= OnInteract) },
            // Cancel
            { new Action(() => playerControls.Cancel.started -= OnCancel) },
        };

        return list;
    }

    public override void Enable()
    {
        base.Enable();
    }

    public override void Disable()
    {
        base.Disable();
    }

    public override void OnUp(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnDown(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnLeft(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnRight(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnSpell(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnEscape(InputAction.CallbackContext context)
    {
        GameStateManager.getInstance.SetCurrentGameState(GameStateEnum.Paused);
    }

    public override void OnInteract(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

    public override void OnCancel(InputAction.CallbackContext context)
    {
        Debug.Log("Play " + context);
    }

}
