using ConsoleTables;

namespace DesignPatterns.Patterns.Builder;

public class BuilderTester : IPatternTester
{
    public void Test()
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

        Console.WriteLine(
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