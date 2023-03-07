using UnityEngine;

public class HumanBehaviour : MonoBehaviour
{
    [SerializeField] Joystick joystick;
    Event update;
    Event fixedUpdate;

    void Start()
    {
        update = new Event();
        fixedUpdate = new Event();

        new Human(new UnityColliderFactory(gameObject, fixedUpdate), new UnityAnimator(GetComponent<Animator>()), update);
        new UnityMoveSystem(joystick, transform, update);
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