using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Creational.Singleton;

public class SingletonTester : PatternTester
{
    public SingletonTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Singleton Pattern";
    protected override void TestImplementation()
    {
        var methodInstance = Database.GetInstance().Query();
        var propertyInstance = Database.Instance.Query();
        
        Logger.LogLine(
            new ConsoleTable("Expression" ,"Result")
                .AddRow("methodInstance", methodInstance)
                .AddRow("propertyInstance", propertyInstance)
                .ToMarkDownString()
        );
    }
}