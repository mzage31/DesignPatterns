using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Adapter;

public class AdapterTester : PatternTester
{
    public AdapterTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Adapter Pattern";

    protected override void TestImplementation()
    {
        var duck = new Duck();
        var turkey = new Turkey();
        var turkeyBeingADuck = new TurkeyDuckAdapter(turkey);
        
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("duck.Quack()", duck.Quack())
                .AddRow("duck.Fly()", duck.Fly())
                .AddRow("turkey.Gobble()", turkey.Gobble())
                .AddRow("turkey.Fly()", turkey.Fly())
                .AddRow("turkeyBeingADuck.Quack()", turkeyBeingADuck.Quack())
                .AddRow("turkeyBeingADuck.Fly()", turkeyBeingADuck.Fly())
                .ToMarkDownString()
        );
    }
}