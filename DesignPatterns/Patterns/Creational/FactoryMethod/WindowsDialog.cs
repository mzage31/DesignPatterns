namespace DesignPatterns.Patterns.Creational.FactoryMethod;

public class WindowsDialog : Dialog
{
    public override Button CreateButton()
    {
        return new Button("Windows Button");
    }
}