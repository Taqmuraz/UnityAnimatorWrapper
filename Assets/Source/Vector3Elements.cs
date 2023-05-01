public class Vector3Elements : IVectorElements
{
    float x;
    float y;
    float z;

    public Vector3Elements(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public float At(int index)
    {
        switch(index)
        {
            case 0: return x;
            case 1: return y;
            case 2: return z;
            default: return 0f;
        }
    }
}
