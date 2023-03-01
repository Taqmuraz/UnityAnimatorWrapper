using UnityEngine;

public class UnityCollider : ICollider
{
    IHumanSize size;
    CapsuleCollider collider;

    public UnityCollider(GameObject gameObject, IHumanSize size, IEvent fixedUpdate)
    {
        this.size = size;
        collider = gameObject.AddComponent<CapsuleCollider>();
        fixedUpdate.Subscribe(FixedUpdate);
    }

    void FixedUpdate()
    {
        collider.radius = size.Radius();
        collider.height = size.Height();
        collider.center = new Vector3(0f, size.Height() * 0.5f, 0f);
    }
}