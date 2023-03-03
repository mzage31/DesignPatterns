using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Proxy;

public class ProxyTester : PatternTester
{
    public ProxyTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Proxy Pattern";

    protected override void TestImplementation()
    {
        IImage image = new ProxyImage("file.png");
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("ProxyImage.Display()", image.Display())
                .ToMarkDownString()
        );
    }
}