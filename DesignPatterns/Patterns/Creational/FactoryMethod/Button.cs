namespace DesignPatterns.Patterns.Creational.FactoryMethod;

public class Button
{
    private readonly string name;

    public Button(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}