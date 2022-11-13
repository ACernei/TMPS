namespace Lab2.FactoryMethod;

public abstract class Polygon
{
    public abstract Shape CreateShape();

    public double CalculatePerimeter()
    {
        var shape = CreateShape();

        return shape.GetPerimeter();
    }

    public double CalculateArea()
    {
        var shape = CreateShape();

        return shape.GetArea();
    }
}
