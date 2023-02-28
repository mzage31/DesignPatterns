using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Patterns.Creational.FactoryMethod;

namespace DesignPatterns;

public class Tester
{
    private readonly AbstractFactoryTester _abstractFactoryTester;
    private readonly BuilderTester _builderTester;
    private readonly FactoryMethodTester _factoryMethodTester;

    public Tester(BuilderTester builderTester, FactoryMethodTester factoryMethodTester, AbstractFactoryTester abstractFactoryTester)
    {
        _builderTester = builderTester;
        _factoryMethodTester = factoryMethodTester;
        _abstractFactoryTester = abstractFactoryTester;
    }

    public void Test()
    {
        _builderTester.Test();
        _factoryMethodTester.Test();
        _abstractFactoryTester.Test();
    }
}