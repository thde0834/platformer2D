using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Events/Game Events/Void Event")]
public class VoidEvent : BaseGameEventSO<Void>
{
    public void Raise() => Raise(new Void());
}
