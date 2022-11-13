namespace Lab2;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public string Color { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}
