namespace Inheritance;

class Parallelogram : BaseTetragon
{
    public override float ConutPerimeter(float a, float b, float c, float d)
    {
        return 2 * (a + b);
    }

    public override float CountArea(float a, float b, float angle)
    {
        return a*b*MathF.Sin(angle);
    }
}