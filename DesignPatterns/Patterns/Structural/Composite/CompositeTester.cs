using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Composite;

public class CompositeTester : PatternTester
{
    public CompositeTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Composite Pattern";

    protected override void TestImplementation()
    {
        var circle = new Circle(10, 10, 5);
        var rectangle = new Rectangle(-10, -10, 10, 20);
        var compound = new CompoundGraphics(
            new Rectangle(0, 0, 200, 5),
            new Circle(-10, 5, 20),
            new CompoundGraphics(
                new Circle(100, 100, 50)
            )
        );
        
        circle.Move(-10, -10);
        rectangle.Move(10, 10);
        compound.Move(10, -5);
        
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("circle", circle.Draw())
                .AddRow("rectangle", rectangle.Draw())
                .AddRow("compound", compound.Draw())
                .ToMarkDownString()
        );
    }
}