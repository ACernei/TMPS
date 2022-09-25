using Lab1;

var shapes = new List<Shape>
{
    new Rectangle {Height = 7, Width = 10},
    new Circle {Radius = 6},
    new Rectangle {Height = 14, Width = 9}
};

var totalArea = AreaCalculator.Calculate(shapes);
var totalPerimeter = PerimeterCalculator.Calculate(shapes);

Console.WriteLine(totalArea);
Console.WriteLine(totalPerimeter);