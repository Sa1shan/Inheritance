namespace Inheritance;

class Square : Rhomb
{
    public override float CountArea(float a, float b, float angle)
    {
        return MathF.Pow(a, 2);
    }    
}