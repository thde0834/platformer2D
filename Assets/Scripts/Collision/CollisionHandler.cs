using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private CollisionDetector[] CollisionDetectors;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach(var detector in CollisionDetectors)
        {
            detector.OnTriggerEnter2D(collision);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (var detector in CollisionDetectors)
        {
            detector.OnTriggerExit2D(collision);
        }
    }
}



