public class HumanIdleState : IHumanState
{
    IHuman human;
    IAnimationInfo animationInfo;

    public HumanIdleState(IHuman human)
    {
        this.human = human;
        animationInfo = human.Animator().Play("Idle");
        UnityEngine.Debug.Log("Entered state : idle");
    }

    public IHumanState Next()
    {
        if (animationInfo.IsPlaying()) return this;
        else return new HumanWalkState(human);
    }
}