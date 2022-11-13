namespace Lab1;

public class Rectangle : Shape
{
    public double Width { get; init; }
    public double Height { get; init; }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}