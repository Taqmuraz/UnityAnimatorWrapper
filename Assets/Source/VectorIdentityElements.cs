public class VectorIdentityElements : IVectorElements
{
    public static readonly IVectorElements identity = new VectorIdentityElements();

    public float At(int index)
    {
        return 0f;
    }
}