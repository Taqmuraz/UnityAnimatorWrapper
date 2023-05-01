using UnityEngine;

public class PlayerBehaviour : MonoBehaviour, IMoveSystemBuilder
{
    RigidbodyMoveSystem moveSystem;

    void Awake()
    {
        new Player(this);
    }

    public void Build(IVector movement, IVector torque)
    {
        moveSystem = new RigidbodyMoveSystem(movement, torque, GetComponent<Rigidbody>());
    }

    void FixedUpdate()
    {
        moveSystem.FixedUpdate();
    }
}