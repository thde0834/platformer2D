using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct CollisionDetector
{
    [SerializeField] private LayerMask DetectLayer;

    [SerializeField] private UnityEvent OnCollisionEnter;
    [SerializeField] private UnityEvent OnCollisionExit;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (DetectLayer == (DetectLayer | (1 << collision.gameObject.layer)))
        {
            OnCollisionEnter.Invoke();
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (DetectLayer == (DetectLayer | (1 << collision.gameObject.layer)))
        {
            OnCollisionExit.Invoke();
        }
    }
}



