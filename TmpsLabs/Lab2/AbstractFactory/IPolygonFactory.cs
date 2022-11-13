namespace Lab2.AbstractFactory;

public interface IPolygonFactory
{
    ISide MakeShortestSide();

    IColor MakeColor();
}
