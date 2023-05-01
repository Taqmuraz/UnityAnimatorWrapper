public class Player
{
    public Player(IMoveSystemBuilder moveSystemBuilder)
    {
        moveSystemBuilder.Build(new MovementVector(new InputVector()), VectorIdentity.identity);
    }
}
