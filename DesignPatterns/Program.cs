using DesignPatterns;
using DesignPatterns.Patterns.Creational.AbstractFactory;
using DesignPatterns.Patterns.Creational.Builder;
using DesignPatterns.Patterns.Creational.FactoryMethod;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();

collection.AddTransient<BuilderTester>();
collection.AddTransient<FactoryMethodTester>();
collection.AddTransient<AbstractFactoryTester>();
collection.AddTransient<Tester>();

var provider = collection.BuildServiceProvider();

provider.GetService<Tester>()?.Test();