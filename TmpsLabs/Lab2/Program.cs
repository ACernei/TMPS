using Lab2;
using Lab2.AbstractFactory;
using Lab2.FactoryMethod;

var rectangleBuilder = new RectangleBuilder();
var rectangle =
    rectangleBuilder.SetWidth(10)
        .SetHeight(15)
        .SetColor("red")
        .Build();

var trapezoidBuilder = new TrapezoidBuilder();
var trapezoid =
    trapezoidBuilder.SetLongBase(20)
        .SetShortBase(8)
        .SetLeftSide(13)
        .SetRightSide(15)
        .SetHeight(10)
        .SetColor("blue")
        .Build();

// Singleton
Console.WriteLine("---Singleton---");

var totalArea1 = AreaCalculator.GetInstance();
var totalArea2 = AreaCalculator.GetInstance();

// Both variables contain the same instance
Console.WriteLine(totalArea1);
Console.WriteLine(totalArea2);

// Factory method
Console.WriteLine("---Factory method---");

var irregularPolygon = new IrregularPolygon(trapezoid);
var regularPolygon = new RegularPolygon(rectangle);

Console.WriteLine($"Trapezoid perimeter: {irregularPolygon.CalculatePerimeter()}");
Console.WriteLine($"Rectangle area: {regularPolygon.CalculateArea()}");

// Abstract factory
Console.WriteLine("---Abstract factory---");

var trapezoidShortestSide = new TrapezoidFactory(trapezoid).MakeShortestSide();
var rectangleColor = new RectangleFactory(rectangle).MakeColor();

Console.WriteLine($"Trapezoid shortest side: {trapezoidShortestSide.GetShortestSide()}");
Console.WriteLine($"Rectangle color: {rectangleColor.GetColor()}");

// Builder
Console.WriteLine("---Builder---");

Console.WriteLine($"Rectangle color: {rectangle.Color}");

// Prototype
Console.WriteLine("---Prototype---");

var rectangleClone = (Rectangle)rectangle.Clone();
Console.WriteLine($"Rectangle clone color: {rectangleClone.Color}");
rectangleClone.Color = "green";
Console.WriteLine($"Rectangle clone color: {rectangleClone.Color}");
