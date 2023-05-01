public class Vector2Elements : IVectorElements
{
    float x;
    float y;

    public Vector2Elements(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float At(int index)
    {
        switch(index)
        {
            case 0: return x;
            case 1: return y;
            default: return 0f;
        }
    }
}
