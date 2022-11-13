namespace Lab2;

public class Trapezoid : Shape
{
    public double LongBase { get; set; }
    public double ShortBase { get; set; }
    public double Height { get; set; }
    public double LeftSide { get; set; }
    public double RightSide { get; set; }
    public string Color { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }

    public override double GetArea()
    {
        return Height * (LongBase + ShortBase) / 2;
    }

    public override double GetPerimeter()
    {
        return LongBase + ShortBase + LeftSide + RightSide;
    }
}
