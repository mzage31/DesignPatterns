namespace DesignPatterns.Patterns.Creational.FactoryMethod;

public class AndroidDialog : Dialog
{
    public override Button CreateButton()
    {
        return new Button("Android Button");
    }
}