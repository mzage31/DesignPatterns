using DesignPatterns.Logger;

namespace DesignPatterns.Patterns;

public abstract class PatternTester
{
    protected readonly ILogger Logger;

    public PatternTester(ILogger logger)
    {
        Logger = logger;
    }

    public void Test()
    {
        var testName = $" {GetName().ToUpper()} ";
        const int count = 50;
        var realCount = count - testName.Length / 2;
        for (var i = 0; i < realCount; i++)
            testName = testName.Insert(0, "/");
        for (var i = 0; i < realCount; i++)
            testName += "\\";
        Logger.LogLine(testName);
        TestImplementation();
    }

    protected abstract string GetName();
    protected abstract void TestImplementation();
}