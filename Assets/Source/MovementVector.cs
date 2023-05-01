public class MovementVector : IVector
{
    IVector input;
    public MovementVector(IVector input)
    {
        this.input = input;
    }
    public void Serve(IVectorClient client)
    {
        input.Serve(new DelegateVectorClient(elements => client.Call(
            new Vector3Elements(
                elements.At(0),
                0f,
                elements.At(1)))));
    }
}
