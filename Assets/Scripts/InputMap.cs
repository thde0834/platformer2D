using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class InputMap : ScriptableObject, GameInput.IGameplayActions
{
    private enum ActionMap
    {
        GamePlay,
    }

    private GameInput gameInput;

    private void OnEnable()
    {
        if (gameInput == null)
        {
            gameInput = new GameInput();
            gameInput.Gameplay.SetCallbacks(this);
        }

        EnableActionMap(ActionMap.GamePlay);
    }

    private void OnDisable()
    {
        //gameInput.FindAction()
    }

    private void EnableActionMap(ActionMap mapKey)
    {
        var actionMap = gameInput.asset.FindActionMap(mapKey.ToString(), true);

        Debug.Log(actionMap);

        actionMap.Enable();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMap(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnEscape(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnCast(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSpellUp(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSpellDown(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSpellLeft(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnSpellRight(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

}
