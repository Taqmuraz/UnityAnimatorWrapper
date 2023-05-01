using UnityEngine;

public class RigidbodyMoveSystem
{
    IVector movement;
    IVector torque;
    Rigidbody body;

    public RigidbodyMoveSystem(IVector movement, IVector torque, Rigidbody body)
    {
        this.movement = movement;
        this.torque = torque;
        this.body = body;
    }

    public void FixedUpdate()
    {
        movement.Serve(new DelegateVectorClient(elements =>
        {
            body.velocity = new Vector3(elements.At(0), elements.At(1), elements.At(2));
        }));
        torque.Serve(new DelegateVectorClient(elements =>
        {
            body.transform.rotation *= Quaternion.Euler(new Vector3(elements.At(0), elements.At(1), elements.At(2)));
        }));
    }
}