using UnityEngine;

[CreateAssetMenu(menuName = "Game Events/Triggers/Void")]
public class VoidEvent : BaseTriggerEvent<Void>
{
    public void Raise() => Raise(new Void());
}
