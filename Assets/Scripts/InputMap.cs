using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class InputMap : PlayerControls.IControlsActions
{
    protected InputManager inputManager;
    protected PlayerControls.ControlsActions playerControls;
    protected List<Action> unsubscribeList;

    public abstract GameStateEnum GameStateEnum { get; }

    public InputMap(InputManager inputManager)
    {
        this.inputManager = inputManager;
        this.playerControls = inputManager.playerControls.Controls;
        unsubscribeList = InitializeUnsubscribeList();
    }

    protected virtual List<Action> InitializeUnsubscribeList() { return null; }

    protected void UnsubscribeActions(List<Action> actions)
    {
        if (actions?.Any() != true) return;

        foreach(var action in actions)
        {
            action();
        }
    }

    public virtual void Enable()
    {
        playerControls.SetCallbacks(this);
        UnsubscribeActions(unsubscribeList);
    }

    public virtual void Disable() { }

    public virtual void OnUp(InputAction.CallbackContext context) { }
    public virtual void OnDown(InputAction.CallbackContext context) { }
    public virtual void OnLeft(InputAction.CallbackContext context) { }
    public virtual void OnRight(InputAction.CallbackContext context) { }
    public virtual void OnJump(InputAction.CallbackContext context) { }
    public virtual void OnSpell(InputAction.CallbackContext context) { }
    public virtual void OnEscape(InputAction.CallbackContext context) { }
    public virtual void OnInteract(InputAction.CallbackContext context) { }
    public virtual void OnCancel(InputAction.CallbackContext context) { }

}
