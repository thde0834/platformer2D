using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PausedInputMap : InputMap
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Paused;

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
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnUp;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnDown(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnDown;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnLeft(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnLeft;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnRight(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnRight;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnEscape(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            GameStateManager.SetCurrentGameState(GameStateEnum.Play);
        }
    }

    public override void OnInteract(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnInteract;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnCancel(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnCancel;
                    return;
                }
            case InputActionPhase.Performed:
                {
                    break;
                }
            case InputActionPhase.Canceled:
                {
                    break;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

}
