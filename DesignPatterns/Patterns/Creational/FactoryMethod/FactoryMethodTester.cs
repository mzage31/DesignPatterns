using ConsoleTables;

namespace DesignPatterns.Patterns.Creational.FactoryMethod;

public class FactoryMethodTester : PatternTester
{
    private enum OS
    {
        Windows,
        Android
    }

    protected override void TestImplementation()
    {
        var os = (OS) Random.Shared.Next(0, 2);
        Dialog randomDialog = os switch
        {
            OS.Windows => new WindowsDialog(),
            OS.Android => new AndroidDialog(),
            _ => throw new ArgumentOutOfRangeException()
        };

        var randomButton = randomDialog.CreateButton();
        var windowsButton = new WindowsDialog().CreateButton();
        var androidButton = new AndroidDialog().CreateButton();
        
        
        Console.WriteLine(
            new ConsoleTable("Variable Name", "Result")
                .AddRow("randomButton", randomButton)
                .AddRow("windowsButton", windowsButton)
                .AddRow("androidButton", androidButton)
                .ToMarkDownString()
        );
    }
}