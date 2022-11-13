namespace Lab1;

public class PerimeterCalculator
{
    public static double Calculate(IEnumerable<Shape> shapes)
    {
        double perimeter = 0;
        foreach (var shape in shapes)
        {
            perimeter += shape.GetPerimeter();
        }

        return perimeter;
    }
}