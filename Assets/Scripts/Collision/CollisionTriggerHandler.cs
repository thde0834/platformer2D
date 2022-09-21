using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class CollisionTriggerHandler : MonoBehaviour
{
    [SerializeField] private LayerMask DetectLayer;

    [SerializeField] private UnityEvent OnCollisionTriggerEnter;
    [SerializeField] private UnityEvent OnCollisionTriggerExit;

    [HideInInspector] public bool IsColliding { get; private set; } = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (OnCollisionTriggerEnter == null) return;

        if (DetectLayer == (DetectLayer | (1 << collision.gameObject.layer)))
        {
            OnCollisionTriggerEnter.Invoke();
            IsColliding = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (OnCollisionTriggerExit == null) return;

        if (DetectLayer == (DetectLayer | (1 << collision.gameObject.layer)))
        {
            OnCollisionTriggerExit.Invoke();
            IsColliding = false;
        }
    }
}
