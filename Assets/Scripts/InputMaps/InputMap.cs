using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class InputMap : PlayerControls.IControlsActions
{
    public abstract GameStateEnum GameStateEnum { get; }

    public virtual void Enable() { }

    public virtual void Disable() { }

    public virtual void OnUp(InputAction.CallbackContext context)
    {
        context.action.started -= OnUp;
        context.action.performed -= OnUp;
        context.action.canceled -= OnUp;
    }
    public virtual void OnDown(InputAction.CallbackContext context)
    {
        context.action.started -= OnDown;
        context.action.performed -= OnDown;
        context.action.canceled -= OnDown;
    }
    public virtual void OnLeft(InputAction.CallbackContext context)
    {
        context.action.started -= OnLeft;
        context.action.performed -= OnLeft;
        context.action.canceled -= OnLeft;
    }
    public virtual void OnRight(InputAction.CallbackContext context)
    {
        context.action.started -= OnRight;
        context.action.performed -= OnRight;
        context.action.canceled -= OnRight;
    }
    public virtual void OnJump(InputAction.CallbackContext context)
    {
        context.action.started -= OnJump;
        context.action.performed -= OnJump;
        context.action.canceled -= OnJump;
    }
    public virtual void OnEscape(InputAction.CallbackContext context)
    {
        context.action.started -= OnEscape;
        context.action.performed -= OnEscape;
        context.action.canceled -= OnEscape;
    }
    public virtual void OnInteract(InputAction.CallbackContext context)
    {
        context.action.started -= OnInteract;
        context.action.performed -= OnInteract;
        context.action.canceled -= OnInteract;
    }
    public virtual void OnCancel(InputAction.CallbackContext context)
    {
        context.action.started -= OnCancel;
        context.action.performed -= OnCancel;
        context.action.canceled -= OnCancel;
    }
    public virtual void OnMap(InputAction.CallbackContext context)
    {
        context.action.started -= OnMap;
        context.action.performed -= OnMap;
        context.action.canceled -= OnMap;
    }
    public virtual void OnCast(InputAction.CallbackContext context)
    {
        context.action.started -= OnCast;
        context.action.performed -= OnCast;
        context.action.canceled -= OnCast;
    }
    public virtual void OnSpellUp(InputAction.CallbackContext context)
    {
        context.action.started -= OnSpellUp;
        context.action.performed -= OnSpellUp;
        context.action.canceled -= OnSpellUp;
    }
    public virtual void OnSpellDown(InputAction.CallbackContext context)
    {
        context.action.started -= OnSpellDown;
        context.action.performed -= OnSpellDown;
        context.action.canceled -= OnSpellDown;
    }
    public virtual void OnSpellLeft(InputAction.CallbackContext context)
    {
        context.action.started -= OnSpellLeft;
        context.action.performed -= OnSpellLeft;
        context.action.canceled -= OnSpellLeft;
    }
    public virtual void OnSpellRight(InputAction.CallbackContext context)
    {
        context.action.started -= OnSpellRight;
        context.action.performed -= OnSpellRight;
        context.action.canceled -= OnSpellRight;
    }

}
