public class FixedHumanSize : IHumanSize
{
    float radius;
    float height;

    public FixedHumanSize(float height, float radius)
    {
        this.height = height;
        this.radius = radius;
    }

    public float Radius()
    {
        return radius;
    }
    public float Height()
    {
        return height;
    }
}