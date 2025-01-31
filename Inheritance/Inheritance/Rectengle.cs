namespace Inheritance;

class Rectengle : Parallelogram
{
    public override float CountArea(float a, float b, float angle)
    {
        return a * b;
    }
}