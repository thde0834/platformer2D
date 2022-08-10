using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu]
public class PlayerWalkMovement : InputActionListener
{
    public override void OnEventRaised(InputAction item) => DoMovement(item.ReadValue<float>());

    public void DoMovement(float value)
    {
        Debug.Log($"{this}: {value}");
    }
}
