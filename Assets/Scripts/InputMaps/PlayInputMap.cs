using UnityEngine;
using UnityEngine.InputSystem;

public class PlayInputMap : InputMap
{
    public override GameStateEnum GameStateEnum => GameStateEnum.Play;
    private PlayerController PlayerController = PlayerController.Instance;

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

    public override void OnJump(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnJump;
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
        if(context.phase == InputActionPhase.Started)
        {
            GameStateManager.SetCurrentGameState(GameStateEnum.Paused);
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

    public override void OnMap(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnMap;
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

    public override void OnCast(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    context.action.started -= OnCast;
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

    public override void OnSpellUp(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    break;
                }
            case InputActionPhase.Performed:
                {
                    context.action.performed -= OnSpellUp;
                    return;
                }
            case InputActionPhase.Canceled:
                {
                    context.action.canceled -= OnSpellUp;
                    return;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnSpellDown(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    break;
                }
            case InputActionPhase.Performed:
                {
                    context.action.performed -= OnSpellDown;
                    return;
                }
            case InputActionPhase.Canceled:
                {
                    context.action.canceled -= OnSpellDown;
                    return;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnSpellLeft(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    break;
                }
            case InputActionPhase.Performed:
                {
                    context.action.performed -= OnSpellLeft;
                    return;
                }
            case InputActionPhase.Canceled:
                {
                    context.action.canceled -= OnSpellLeft;
                    return;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }

    public override void OnSpellRight(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Started:
                {
                    break;
                }
            case InputActionPhase.Performed:
                {
                    context.action.performed -= OnSpellRight;
                    return;
                }
            case InputActionPhase.Canceled:
                {
                    context.action.canceled -= OnSpellRight;
                    return;
                }
        }
        Debug.Log(GameStateEnum.ToString() + context);

    }
}