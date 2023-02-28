namespace DesignPatterns.Patterns.Creational.AbstractFactory;

public class MacUIFactory : UIFactory
{
    public Button CreateButton()
    {
        return new Button("Mac Button");
    }

    public CheckBox CreateCheckBox(bool defaultValue)
    {
        return new CheckBox("Mac CheckBox", defaultValue);
    }
}