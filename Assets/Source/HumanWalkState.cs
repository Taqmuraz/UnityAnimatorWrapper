public class HumanWalkState : IHumanState
{
    IHuman human;
    IAnimationInfo animationInfo;

    public HumanWalkState(IHuman human)
    {
        this.human = human;
        animationInfo = human.Animator().Play("Walk");
        UnityEngine.Debug.Log("Entered state : walk");
    }

    public IHumanState Next()
    {
        if (animationInfo.IsPlaying()) return this;
        else return new HumanIdleState(human);
    }
}

