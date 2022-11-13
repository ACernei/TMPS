namespace Lab2.AbstractFactory;

public class RectangleColor : IColor
{
    private readonly Rectangle rectangle;

    public RectangleColor(Rectangle rectangle)
    {
        this.rectangle = rectangle;
    }

    public string GetColor()
    {
        return rectangle.Color;
    }
}
