namespace Lab2;

public class TrapezoidBuilder
{
    private Trapezoid trapezoid = new();
    public Trapezoid Build() => trapezoid;

    public TrapezoidBuilder SetLongBase(double longBase)
    {
        trapezoid.LongBase = longBase;
        return this;
    }

    public TrapezoidBuilder SetShortBase(double shortBase)
    {
        trapezoid.ShortBase = shortBase;
        return this;
    }

    public TrapezoidBuilder SetHeight(double height)
    {
        trapezoid.Height = height;
        return this;
    }

    public TrapezoidBuilder SetLeftSide(double leftSide)
    {
        trapezoid.LeftSide = leftSide;
        return this;
    }

    public TrapezoidBuilder SetRightSide(double rightSide)
    {
        trapezoid.RightSide = rightSide;
        return this;
    }
    public TrapezoidBuilder SetColor(string color)
    {
        trapezoid.Color = color;
        return this;
    }
}
