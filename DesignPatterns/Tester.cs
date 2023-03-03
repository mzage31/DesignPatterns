using DesignPatterns.Logger;
using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Patterns.Creational.FactoryMethod;
using DesignPatterns.Patterns.Creational.Prototype;
using DesignPatterns.Patterns.Creational.Singleton;

namespace DesignPatterns;

public class Tester
{
    private readonly ILogger _logger;
    private readonly AbstractFactoryTester _abstractFactoryTester;
    private readonly BuilderTester _builderTester;
    private readonly FactoryMethodTester _factoryMethodTester;
    private readonly SingletonTester _singletonTester;
    private readonly PrototypeTester _prototypeTester;

    public Tester(
        ILogger logger,
        BuilderTester builderTester,
        FactoryMethodTester factoryMethodTester,
        AbstractFactoryTester abstractFactoryTester,
        SingletonTester singletonTester,
        PrototypeTester prototypeTester
    )
    {
        _logger = logger;

        // creational patterns
        _builderTester = builderTester;
        _factoryMethodTester = factoryMethodTester;
        _abstractFactoryTester = abstractFactoryTester;
        _singletonTester = singletonTester;
        _prototypeTester = prototypeTester;
    }

    public void Test()
    {
        // creational patterns
        _builderTester.Test();
        _factoryMethodTester.Test();
        _abstractFactoryTester.Test();
        _singletonTester.Test();
        _prototypeTester.Test();

        _logger.Display();
    }
}