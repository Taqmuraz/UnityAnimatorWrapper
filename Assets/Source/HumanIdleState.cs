public class HumanIdleState : IHumanState
{
    IHuman human;
    IAnimationInfo animationInfo;
    IHumanSize size;

    public HumanIdleState(IHuman human)
    {
        this.human = human;
        animationInfo = human.Animator().Play("Idle");
        size = new FixedHumanSize(1.8f, 0.25f);
    }

    public IHumanState Next()
    {
        if (animationInfo.IsPlaying()) return this;
        else return new HumanCrouchState(human);
    }

    public IHumanSize Size()
    {
        return size;
    }
}