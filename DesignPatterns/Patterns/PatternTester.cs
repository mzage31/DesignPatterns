namespace DesignPatterns.Patterns;

public abstract class PatternTester
{
    public void Test()
    {
        var testName = $" {GetType().Name} ";
        const int count = 40;
        var realCount = count - testName.Length / 2;
        for (var i = 0; i < realCount; i++)
            testName = testName.Insert(0, "-");
        for (var i = 0; i < realCount; i++)
            testName += "-";
        Console.WriteLine(testName);
        TestImplementation();
    }
    
    protected abstract void TestImplementation();
}