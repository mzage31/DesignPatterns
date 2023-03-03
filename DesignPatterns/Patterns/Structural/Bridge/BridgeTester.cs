using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Bridge;

public class BridgeTester : PatternTester
{
    public BridgeTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Bridge Pattern";

    protected override void TestImplementation()
    {
        var tv = new Tv();
        var tvRemote = new AdvancedRemoteControl(tv);
        tvRemote.TogglePower();
        tvRemote.VolumeUp();
        tvRemote.VolumeUp();
        tvRemote.VolumeUp();
        
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("tv.IsOn()", tv.IsOn())
                .AddRow("tv.GetVolume()", tv.GetVolume())
                .ToMarkDownString()
        );
    }
}