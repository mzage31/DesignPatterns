using DesignPatterns;
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
using Microsoft.Extensions.DependencyInjection;

var fileLoggerPath = Directory.GetCurrentDirectory() + "/design-pattern-tests.log";

var collection = new ServiceCollection();

collection.AddSingleton<ILogger, FileLogger>(_ => new FileLogger(fileLoggerPath));

// creational patterns
collection.AddTransient<BuilderTester>();
collection.AddTransient<FactoryMethodTester>();
collection.AddTransient<AbstractFactoryTester>();
collection.AddTransient<SingletonTester>();
collection.AddTransient<PrototypeTester>();

// structural patterns
collection.AddTransient<AdapterTester>();
collection.AddTransient<BridgeTester>();
collection.AddTransient<CompositeTester>();
collection.AddTransient<DecoratorTester>();
collection.AddTransient<FlyWeightTester>();
collection.AddTransient<FacadeTester>();

collection.AddTransient<Tester>();
var provider = collection.BuildServiceProvider();

provider.GetService<Tester>()?.Test();
