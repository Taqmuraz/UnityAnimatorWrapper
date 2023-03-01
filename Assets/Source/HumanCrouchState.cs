public class HumanCrouchState : IHumanState
{
    IHuman human;
    IAnimationInfo animationInfo;
    IHumanSize size;

    public HumanCrouchState(IHuman human)
    {
        this.human = human;
        animationInfo = human.Animator().Play("Crouch");
        size = new FixedHumanSize(1f, 0.4f);
    }

    public IHumanState Next()
    {
        if (animationInfo.IsPlaying()) return this;
        else return new HumanIdleState(human);
    }

    public IHumanSize Size()
    {
        return size;
    }
}
