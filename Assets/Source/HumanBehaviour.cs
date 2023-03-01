using UnityEngine;

public class HumanBehaviour : MonoBehaviour
{
    Event update;
    Event fixedUpdate;

    void Start()
    {
        update = new Event();
        fixedUpdate = new Event();

        new Human(new UnityColliderFactory(gameObject, fixedUpdate), new UnityAnimator(GetComponent<Animator>()), update);
    }

    void Update()
    {
        update.Call();
    }
    void FixedUpdate()
    {
        fixedUpdate.Call();
    }
}