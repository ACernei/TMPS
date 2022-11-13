namespace Lab2.FactoryMethod;

public class RegularPolygon : Polygon
{
    private readonly Rectangle rectangle;
    public RegularPolygon(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public override Shape CreateShape()
    {
        return rectangle;
    }
}
