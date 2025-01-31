namespace Inheritance;

class Rhomb : Parallelogram
{
    public override float ConutPerimeter(float a, float b, float c, float d)
    {
        return 4 * a;
    }

    public override float CountArea(float a, float b, float angle)
    {
        return MathF.Pow(a, 2) * MathF.Sin(angle);
    }
}