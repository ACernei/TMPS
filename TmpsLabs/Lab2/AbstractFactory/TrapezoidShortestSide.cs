namespace Lab2.AbstractFactory;

public class TrapezoidShortestSide : ISide
{
    private readonly Trapezoid trapezoid;

    public TrapezoidShortestSide(Trapezoid trapezoid)
    {
        this.trapezoid = trapezoid;
    }

    public double GetShortestSide()
    {
        var sides = new List<double>
        {
            trapezoid.LongBase,
            trapezoid.ShortBase,
            trapezoid.LeftSide,
            trapezoid.RightSide
        };

        return sides.AsQueryable().Min();
    }
}
