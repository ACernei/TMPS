namespace Lab1;

public class Circle : Shape
{
    public double Radius { get; init; }

    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}