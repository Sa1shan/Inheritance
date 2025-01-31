namespace Inheritance;
class Tetragon : BaseTetragon
{
    public override float ConutPerimeter(float a, float b, float c, float d)
    {
        return a + b + c + d;
    }

    public override float CountArea(float a, float b, float angle)
    {
       return 0.5f * a*b*MathF.Sin(angle);
    }
}