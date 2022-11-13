namespace Lab2.AbstractFactory;

public class TrapezoidColor : IColor
{
    private readonly Trapezoid trapezoid;

    public TrapezoidColor(Trapezoid trapezoid)
    {
        this.trapezoid = trapezoid;
    }

    public string GetColor()
    {
        return trapezoid.Color;
    }
}
