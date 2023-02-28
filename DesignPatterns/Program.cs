using DesignPatterns;
using DesignPatterns.Logger;
using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Patterns.Creational.FactoryMethod;
using DesignPatterns.Patterns.Creational.Singleton;
using Microsoft.Extensions.DependencyInjection;

var fileLoggerPath = Directory.GetCurrentDirectory() + "/design-pattern-tests.log";

var collection = new ServiceCollection();
collection.AddSingleton<ILogger, FileLogger>(_ => new FileLogger(fileLoggerPath));
collection.AddTransient<BuilderTester>();
collection.AddTransient<FactoryMethodTester>();
collection.AddTransient<AbstractFactoryTester>();
collection.AddTransient<SingletonTester>();
collection.AddTransient<Tester>();
var provider = collection.BuildServiceProvider();

provider.GetService<Tester>()?.Test();
