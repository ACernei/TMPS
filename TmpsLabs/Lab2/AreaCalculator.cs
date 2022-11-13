namespace Lab2;

public class AreaCalculator
{
    private static AreaCalculator instance;

    private AreaCalculator()
    {
    }

    public static AreaCalculator GetInstance()
    {
        if (instance == null)
        {
            instance = new AreaCalculator();
        }

        return instance;
    }

    public double Calculate(IEnumerable<Shape> shapes)
    {
        double area = 0;
        foreach (var shape in shapes)
        {
            area += shape.GetArea();
        }

        return area;
    }
}
