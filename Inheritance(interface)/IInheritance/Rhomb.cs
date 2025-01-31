namespace IInheritance;

class Rhomb : Parallelogram
{
    public float ConutPerimeter(float a, float b, float c, float d)
    {
        return 4 * a;
    }

    public float CountArea(float a, float b, float angle)
    {
        return MathF.Pow(a, 2) * MathF.Sin(angle);
    }
}