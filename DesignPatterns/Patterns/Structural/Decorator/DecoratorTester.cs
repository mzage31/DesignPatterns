using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Decorator;

public class DecoratorTester : PatternTester
{
    public DecoratorTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Decorator Pattern";

    protected override void TestImplementation()
    {
        IClothed person = new Person();
        person = new ShirtDecorator(person);
        person = new PantsDecorator(person);
        person = new ShoesDecorator(person);
        IClothed personWithJacket = new JacketDecorator(person);
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("person's clothes", person.WhatAreYouWearing())
                .AddRow("personWithJacket's clothes", personWithJacket.WhatAreYouWearing())
                .ToMarkDownString()
        );
    }
}