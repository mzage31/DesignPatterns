namespace DesignPatterns.Patterns.Creational.AbstractFactory;

public class WindowsUIFactory : UIFactory
{
    public Button CreateButton()
    {
        return new Button("Windows Button");
    }

    public CheckBox CreateCheckBox(bool defaultValue)
    {
        return new CheckBox("Windows CheckBox", defaultValue);
    }
}