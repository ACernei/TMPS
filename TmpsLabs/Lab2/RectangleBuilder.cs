namespace Lab2;

public class RectangleBuilder
{
    private Rectangle rectangle = new();
    public Rectangle Build() => rectangle;

    public RectangleBuilder SetHeight(double height)
    {
        rectangle.Height = height;
        return this;
    }

    public RectangleBuilder SetWidth(double width)
    {
        rectangle.Width = width;
        return this;
    }

    public RectangleBuilder SetColor(string color)
    {
        rectangle.Color = color;
        return this;
    }
}
