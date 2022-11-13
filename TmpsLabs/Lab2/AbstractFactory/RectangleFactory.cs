namespace Lab2.AbstractFactory;

public class RectangleFactory : IPolygonFactory
{
    private readonly Rectangle rectangle;

    public RectangleFactory(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public ISide MakeShortestSide()
    {
        return new RectangleShortestSide(rectangle);
    }

    public IColor MakeColor()
    {
        return new RectangleColor(rectangle);
    }
}
