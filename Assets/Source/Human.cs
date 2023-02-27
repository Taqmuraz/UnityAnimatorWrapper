public class Human : IHuman
{
    IAnimator animator;
    IHumanState state;

    public Human(IAnimator animator)
    {
        this.animator = animator;
        state = new HumanWalkState(this);
    }

    public IAnimator Animator()
    {
        return animator;
    }

    public void Update()
    {
        state = state.Next();
    }
}