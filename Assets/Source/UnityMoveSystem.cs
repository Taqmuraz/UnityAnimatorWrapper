using UnityEngine;

public class UnityMoveSystem
{
    IController controller;
    Transform transform;

    public UnityMoveSystem(IController controller, Transform transform, IEvent updateEvent)
    {
        this.controller = controller;
        this.transform = transform;
        updateEvent.Subscribe(Update);
    }

    void Update()
    {
        Vector2 input = controller.Movement();
        transform.position += new Vector3(input.x, 0f, input.y) * Time.deltaTime * 5f;
    }
}