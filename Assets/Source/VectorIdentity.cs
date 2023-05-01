public class VectorIdentity : IVector
{
    public static readonly IVector identity = new VectorIdentity();

    public void Serve(IVectorClient client)
    {
        client.Call(VectorIdentityElements.identity);
    }
}
