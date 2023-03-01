using UnityEngine;

public class UnityColliderFactory : IColliderFactory
{
    GameObject gameObject;
    IEvent fixedUpdate;

    public UnityColliderFactory(GameObject gameObject, IEvent fixedUpdate)
    {
        this.gameObject = gameObject;
        this.fixedUpdate = fixedUpdate;
    }

    public ICollider CreateCollider(IHumanSize size)
    {
        return new UnityCollider(gameObject, size, fixedUpdate);
    }
}