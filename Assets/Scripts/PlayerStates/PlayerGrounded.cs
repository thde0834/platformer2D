using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "PlayerGrounded", menuName = "EntityStates/PlayerStates/Grounded")]
public class PlayerGrounded : PlayerState
{
    public override EntityStateEnum EntityStateEnum => EntityStateEnum.Grounded;

    public override void OnEnable()
    {
        // sub to when player jumps to enter aerial state
        //BottomCollider.OnPlatformExit +=

        // sub when shift is pressed to cast spell
        // action?
    }

    public override void OnDisable()
    {
           
    }

    public override void OnUpPerformed()
    {
        // start coroutine

    }

    public override void OnUpCanceled()
    {
        // end coroutine
    }

    public override void OnDownPerformed()
    {
        base.OnDownPerformed();
    }

    public override void OnDownCanceled()
    {
        base.OnDownCanceled();
    }

    public override void OnLeftPerformed()
    {
        base.OnLeftPerformed();
    }

    public override void OnLeftCanceled()
    {
        base.OnLeftCanceled();
    }

    public override void OnRightPerformed()
    {
        base.OnRightPerformed();
    }

    public override void OnRightCanceled()
    {
        base.OnRightCanceled();
    }

    public override void OnJumpPerformed()
    {
        // best way to access rigidbody???
    }

    public override void OnJumpCanceled()
    {
        base.OnJumpCanceled();
    }

    public override void OnInteractStarted()
    {
        base.OnInteractStarted();
    }

    public override void OnMapStarted()
    {
        base.OnMapStarted();
    }

    public override void OnCastStarted()
    {
        base.OnCastStarted();
    }
}
