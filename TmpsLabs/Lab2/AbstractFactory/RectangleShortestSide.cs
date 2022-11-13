namespace Lab2.AbstractFactory;

public class RectangleShortestSide : ISide
{
    private readonly Rectangle rectangle;

    public RectangleShortestSide(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public double GetShortestSide()
    {
        var sides = new List<double>
        {
            rectangle.Width,
            rectangle.Height
        };

        return sides.AsQueryable().Min();
    }
}
