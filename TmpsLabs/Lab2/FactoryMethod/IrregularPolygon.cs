namespace Lab2.FactoryMethod;

public class IrregularPolygon : Polygon
{
    private readonly Trapezoid trapezoid;

    public IrregularPolygon(Trapezoid trapezoid)
    {
        this.trapezoid = trapezoid;
    }

    public override Shape CreateShape()
    {
        return trapezoid;
    }
}
