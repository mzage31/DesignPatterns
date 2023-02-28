﻿using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Creational.AbstractFactory;

public class AbstractFactoryTester : PatternTester
{
    public AbstractFactoryTester(ILogger logger) : base(logger)
    {
    }

    protected override void TestImplementation()
    {
        var windowsUiFactory = new WindowsUIFactory();
        var macUiFactory = new MacUIFactory();

        var windowsButton = windowsUiFactory.CreateButton();
        var windowsCheckBox = windowsUiFactory.CreateCheckBox(true);

        var macButton = macUiFactory.CreateButton();
        var macCheckBox = macUiFactory.CreateCheckBox(false);

        Logger.LogLine(
            new ConsoleTable("Variable Name", "Result")
                .AddRow("windowsButton", windowsButton)
                .AddRow("windowsCheckBox", windowsCheckBox)
                .AddRow("macButton", macButton)
                .AddRow("macCheckBox", macCheckBox)
                .ToMarkDownString()
        );
    }
}