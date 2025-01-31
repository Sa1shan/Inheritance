namespace IInheritance;

class Square : Rhomb
{
    public float CountArea(float a, float b, float angle)
    {
        return MathF.Pow(a, 2);
    }    
}