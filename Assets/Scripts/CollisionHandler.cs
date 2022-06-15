using UnityEngine;

public abstract class CollisionHandler : MonoBehaviour
{
    protected enum CollisionEvent
    {
        Enter, Exit
    }

    public LayerMask[] LayerMasks;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var layer = collision.gameObject.layer;
        foreach(var layerMask in LayerMasks)
        {
            if (layerMask == (layerMask | (1 << layer)))
            {
                OnCollisionEvent(CollisionEvent.Enter, layer);
                return;
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        var layer = collision.gameObject.layer;
        foreach (var layerMask in LayerMasks)
        {
            if (layerMask == (layerMask | (1 << layer)))
            {
                OnCollisionEvent(CollisionEvent.Exit, layer);
                return;
            }
        }
    }

    protected abstract void OnCollisionEvent(CollisionEvent context, int layer);
}
