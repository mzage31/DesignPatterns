using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Creational.Builder;

public class BuilderTester : PatternTester
{
    public BuilderTester(ILogger logger) : base(logger)
    {
    }

    protected override void TestImplementation()
    {
        var pizzaBuilder = new Pizza.Builder();
        var pizzaDirector = new Pizza.Director(pizzaBuilder);

        var pizzaDescriptorBuilder = new PizzaDescriptor.Builder();
        var pizzaDescriptorDirector = new PizzaDescriptor.Director(pizzaDescriptorBuilder);

        var builtPepperoniPizza = pizzaBuilder
            .AddPepperoni()
            .Build();

        var builtChickenPizza = pizzaBuilder
            .AddChicken()
            .Build();

        var builtPizzaDescriptor = pizzaDescriptorBuilder
            .AddChicken()
            .AddPepper()
            .Build();

        var directedPizza = pizzaDirector.MakePepperoniPizza();
        var directedPizzaDescriptor = pizzaDescriptorDirector.MakeChickenPizza();

        Logger.LogLine(
            new ConsoleTable("Variable Name", "Result")
                .AddRow("builtPepperoniPizza", builtPepperoniPizza)
                .AddRow("builtChickenPizza", builtChickenPizza)
                .AddRow("builtPizzaDescriptor", builtPizzaDescriptor)
                .AddRow("directedPizza", directedPizza)
                .AddRow("directedPizzaDescriptor", directedPizzaDescriptor)
                .ToMarkDownString()
        );
    }
}