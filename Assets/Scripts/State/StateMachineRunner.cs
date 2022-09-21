using UnityEngine;

public class StateMachineRunner : MonoBehaviour
{
    [field: SerializeField] public StateMachine StateMachine { get; private set; }

    private void Start()
    {
        // Creates and retrieves a clone of a StateMachineGraph
        // so that no two StateMachines are working with the same StateMachineGraph
        StateMachine = StateMachine.Clone();
    }
    
}
