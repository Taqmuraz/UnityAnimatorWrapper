using UnityEngine;

public class UnityAnimator : IAnimator
{
    Animator animator;

    public UnityAnimator(Animator animator)
    {
        this.animator = animator;
    }

    public IAnimationInfo Play(string name)
    {
        animator.Play(name);
        return new UnityAnimationInfo(animator, name);
    }
}