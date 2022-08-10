using UnityEngine;

[CreateAssetMenu(menuName = "Game Events/Game Events/Void")]
public class VoidEvent : BaseGameEvent<Void>
{
    public void Raise() => Raise(new Void());
}
