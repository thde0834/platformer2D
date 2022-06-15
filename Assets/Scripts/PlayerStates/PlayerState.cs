using UnityEngine.InputSystem;


// Entity states will need Decisions to execute actions
// Player states need Player Input to execute actions
public abstract class PlayerState : EntityState
{
    public virtual void OnUpStarted() { }
    public virtual void OnUpPerformed() { }
    public virtual void OnUpCanceled() { }
    public virtual void OnDownStarted() { }
    public virtual void OnDownPerformed() { }
    public virtual void OnDownCanceled() { }
    public virtual void OnLeftStarted() { }
    public virtual void OnLeftPerformed() { }
    public virtual void OnLeftCanceled() { }
    public virtual void OnRightStarted() { }
    public virtual void OnRightPerformed() { }
    public virtual void OnRightCanceled() { }
    public virtual void OnJumpStarted() { }
    public virtual void OnJumpPerformed() { }
    public virtual void OnJumpCanceled() { }
    public virtual void OnInteractStarted() { }
    public virtual void OnInteractPerformed() { }
    public virtual void OnInteractCanceled() { }
    public virtual void OnCancelStarted() { }
    public virtual void OnCancelPerformed() { }
    public virtual void OnCancelCanceled() { }
    public virtual void OnMapStarted() { }
    public virtual void OnMapPerformed() { }
    public virtual void OnMapCanceled() { }
    public virtual void OnCastStarted() { }
    public virtual void OnCastPerformed() { }
    public virtual void OnCastCanceled() { }

}
