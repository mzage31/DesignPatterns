using DesignPatterns.Logger;
using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Patterns.Creational.FactoryMethod;
using DesignPatterns.Patterns.Creational.Prototype;
using DesignPatterns.Patterns.Creational.Singleton;
using DesignPatterns.Patterns.Structural.Adapter;
using DesignPatterns.Patterns.Structural.Bridge;
using DesignPatterns.Patterns.Structural.Composite;
using DesignPatterns.Patterns.Structural.Decorator;
using DesignPatterns.Patterns.Structural.Facade;
using DesignPatterns.Patterns.Structural.Flyweight;

namespace DesignPatterns;

public class Tester
{
    private readonly ILogger _logger;
    private readonly AbstractFactoryTester _abstractFactoryTester;
    private readonly BuilderTester _builderTester;
    private readonly FactoryMethodTester _factoryMethodTester;
    private readonly SingletonTester _singletonTester;
    private readonly PrototypeTester _prototypeTester;
    private readonly AdapterTester _adapterTester;
    private readonly BridgeTester _bridgeTester;
    private readonly CompositeTester _compositeTester;
    private readonly DecoratorTester _decoratorTester;
    private readonly FlyWeightTester _flyWeightTester;
    private readonly FacadeTester _facadeTester;

    public Tester(ILogger logger,
        BuilderTester builderTester,
        FactoryMethodTester factoryMethodTester,
        AbstractFactoryTester abstractFactoryTester,
        SingletonTester singletonTester,
        PrototypeTester prototypeTester,
        AdapterTester adapterTester,
        BridgeTester bridgeTester,
        CompositeTester compositeTester,
        DecoratorTester decoratorTester,
        FlyWeightTester flyWeightTester,
        FacadeTester facadeTester
    )
    {
        _logger = logger;

        // creational patterns
        _builderTester = builderTester;
        _factoryMethodTester = factoryMethodTester;
        _abstractFactoryTester = abstractFactoryTester;
        _singletonTester = singletonTester;
        _prototypeTester = prototypeTester;

        // structural patterns
        _adapterTester = adapterTester;
        _bridgeTester = bridgeTester;
        _compositeTester = compositeTester;
        _decoratorTester = decoratorTester;
        _flyWeightTester = flyWeightTester;
        _facadeTester = facadeTester;
    }

    public void Test()
    {
        // creational patterns
        _builderTester.Test();
        _factoryMethodTester.Test();
        _abstractFactoryTester.Test();
        _singletonTester.Test();
        _prototypeTester.Test();

        // structural patterns
        _adapterTester.Test();
        _bridgeTester.Test();
        _compositeTester.Test();
        _decoratorTester.Test();
        _flyWeightTester.Test();
        _facadeTester.Test();

        _logger.Display();
    }
}