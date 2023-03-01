public class Human : IHuman
{
    class HumanSize : IHumanSize
    {
        Human human;
        public HumanSize(Human human)
        {
            this.human = human;
        }
        public float Radius()
        {
            return human.state.Size().Radius();
        }
        public float Height()
        {
            return human.state.Size().Height();
        }
    }

    IAnimator animator;
    IHumanState state;

    public Human(IColliderFactory colliderFactory, IAnimator animator, IEvent updateEvent)
    {
        this.animator = animator;
        state = new HumanCrouchState(this);
        colliderFactory.CreateCollider(new HumanSize(this));
        updateEvent.Subscribe(() => state = state.Next());
    }

    public IAnimator Animator()
    {
        return animator;
    }
}