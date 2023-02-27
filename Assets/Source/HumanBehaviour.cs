using UnityEngine;

public class HumanBehaviour : MonoBehaviour
{
    Human human;

    void Start()
    {
        human = new Human(new UnityAnimator(GetComponent<Animator>()));
    }

    void Update()
    {
        human.Update();
    }
}