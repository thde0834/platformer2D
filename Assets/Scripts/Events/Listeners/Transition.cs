
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "Game Events/Listeners/Transition")]
public class Transition : BaseGameEventListener<Void, VoidEvent>
{
    [field: SerializeField] public BaseState TargetState { get; private set; }

    public Transition Clone() => Instantiate(this);

    public override void OnEventRaised(Void item) => TargetState.ActivateState();

}
