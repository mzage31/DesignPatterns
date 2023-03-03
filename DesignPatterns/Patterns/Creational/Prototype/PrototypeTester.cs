using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Creational.Prototype;

public class PrototypeTester : PatternTester
{
    public PrototypeTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Prototype Pattern";

    protected override void TestImplementation()
    {
        var rectangle = new Rectangle(0, 0, 10, 20);
        var circle = new Circle(10, 20, 10);
        rectangle.CalculateArea();

        var clonedRectangle = rectangle.Clone(); // private field member "calculatedArea" is passed to the cloned object. we don't have to call "CalculateArea"
        var clonedCircle = circle.Clone();
        clonedRectangle.X = 100;
        clonedCircle.Radius += 5;

        var clonedRectangleByConstructor = new Rectangle(rectangle) { Height = 500 };
        var clonedCircleByConstructor = new Circle(circle) { X = -10, Y = 0 };

        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("rectangle", rectangle)
                .AddRow("circle", circle)
                .AddRow("clonedRectangle", clonedRectangle)
                .AddRow("clonedCircle", clonedCircle)
                .AddRow("clonedRectangleByConstructor", clonedRectangleByConstructor)
                .AddRow("clonedCircleByConstructor", clonedCircleByConstructor)
                .ToMarkDownString()
        );
    }
}