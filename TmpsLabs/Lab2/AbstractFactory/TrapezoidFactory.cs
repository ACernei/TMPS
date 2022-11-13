namespace Lab2.AbstractFactory;

public class TrapezoidFactory : IPolygonFactory
{
    private readonly Trapezoid trapezoid;

    public TrapezoidFactory(Trapezoid trapezoid)
    {
        this.trapezoid = trapezoid;
    }

    public ISide MakeShortestSide()
    {
        return new TrapezoidShortestSide(trapezoid);
    }

    public IColor MakeColor()
    {
        return new TrapezoidColor(trapezoid);
    }
}
