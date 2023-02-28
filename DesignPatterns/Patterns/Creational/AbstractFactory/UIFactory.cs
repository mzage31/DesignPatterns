namespace DesignPatterns.Patterns.Creational.AbstractFactory;

public interface UIFactory
{
    Button CreateButton();
    CheckBox CreateCheckBox(bool defaultValue);
}