namespace Lab2;

public class PerimeterCalculator
{
    private static PerimeterCalculator instance;

    private PerimeterCalculator()
    {
    }

    public static PerimeterCalculator GetInstance()
    {
        if (instance == null)
        {
            instance = new PerimeterCalculator();
        }

        return instance;
    }

    public double Calculate(IEnumerable<Shape> shapes)
    {
        double perimeter = 0;
        foreach (var shape in shapes)
        {
            perimeter += shape.GetPerimeter();
        }

        return perimeter;
    }
}
