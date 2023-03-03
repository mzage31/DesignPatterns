using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Facade;

public class FacadeTester : PatternTester
{
    public FacadeTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Facade Pattern";

    protected override void TestImplementation()
    {
        var converter = new VideoConverterFacade();
        var result = converter.Convert("cats1.mp4", "cats2.webm");
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("VideoConverterFacade.Convert()", result)
                .ToMarkDownString()
        );
    }
}