namespace IInheritance;

class Parallelogram : ITetragon
{
    public float ConutPerimeter(float a, float b, float c, float d)
    {
        return 2 * (a + b);
    }

    public float CountArea(float a, float b, float angle)
    {
        return a*b*MathF.Sin(angle);
    }
}