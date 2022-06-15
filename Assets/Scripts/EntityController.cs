using UnityEngine;

public abstract class EntityController : MonoBehaviour
{
    public static EntityController Instance { get; private set; }
    [field: SerializeField] public EntityStateMachine EntityStateMachine { get; private set; }
    [field: SerializeField] public Rigidbody2D Rigidbody { get; private set; }

    [field: SerializeField] protected EntityState[] entityStates;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        EntityStateMachine = GetComponent<EntityStateMachine>();
        EntityStateMachine.InitializeStateMachine(this, entityStates);

        Rigidbody = GetComponent<Rigidbody2D>();
    }

}

