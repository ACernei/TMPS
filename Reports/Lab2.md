# Design Patterns

In this project I implemented 5 creational design patterns

- Abstract Factory - Creates families of related dependent objects
- Factory - Creates objects of several related classes without specifying the exact object to be created
- Builder -  Constructs objects using step-by-step approach
- Singleton - A class should have only one instance at a time
- Prototype - Makes copies of existing objects without making the code dependent on their classes.

## Abstract Factory
The pattern is easy to recognize by methods, which return a factory object. Then, the factory is used for creating specific sub-components.

Both rectangle factory and trapezoid factory implements polygon factory

```
public interface IPolygonFactory
{
    ISide MakeShortestSide();

    IColor MakeColor();
}
```

```
public class RectangleFactory : IPolygonFactory
{
    public ISide MakeShortestSide()
    {
        return new RectangleShortestSide(rectangle);
    }

    public IColor MakeColor()
    {
        return new RectangleArea(rectangle);
    }
}
```
```
public class RectangleColor : IColor
{
    public string GetColor()
    {
        return rectangle.Color;
    }
}
```
## Factory method
Factory method solves the problem of creating product objects without specifying their concrete classes.

```
public abstract Shape CreateShape();

public double CalculatePerimeter()
{
    var shape = CreateShape();

    return shape.GetPerimeter();
}

public double CalculateArea()
{
    var shape = CreateShape();

    return shape.GetArea();
}
```
```
var irregularPolygon = new IrregularPolygon(trapezoid);
var regularPolygon = new RegularPolygon(rectangle);
```
## Builder

Builder separates the construction of a complex object from its representation so that the same construction process can create different representations.
```
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
```

```
var rectangleBuilder = new RectangleBuilder();
var rectangle =
    rectangleBuilder.SetHeight(10)
        .SetHeight(15)
        .SetColor("red")
        .Build();
```
## Singleton

Singleton ensure a class has only one instance, and provide a global point of access to it.
```
public static AreaCalculator GetInstance()
{
    if (instance == null)
    {
        instance = new AreaCalculator();
    }

    return instance;
}
```
## Prototype

Prototype specifies the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

```
public override Shape Clone()
{
    return (Shape)this.MemberwiseClone();
}
```
```
var rectangleClone = (Rectangle)rectangle.Clone();
Console.WriteLine($"Rectangle clone color: {rectangleClone.Color}");

rectangleClone.Color = "green";
Console.WriteLine($"Rectangle clone color: {rectangleClone.Color}");
```

