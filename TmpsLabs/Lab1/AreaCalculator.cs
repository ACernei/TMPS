namespace Lab1;

public static class AreaCalculator
{
    public static double Calculate(IEnumerable<Shape> shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.GetArea();
        }

        return area;
    }
}