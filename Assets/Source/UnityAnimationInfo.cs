using UnityEngine;

public class UnityAnimationInfo : IAnimationInfo
{
    Animator animator;
    string name;
    float start;

    public UnityAnimationInfo(Animator animator, string name)
    {
        this.animator = animator;
        this.name = name;
        this.start = Time.time;
    }
    public bool IsPlaying()
    {
        var stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName(name) && stateInfo.length > (Time.time - start);
    }
}