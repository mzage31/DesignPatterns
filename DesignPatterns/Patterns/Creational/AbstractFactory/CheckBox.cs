namespace DesignPatterns.Patterns.Creational.AbstractFactory;

public class CheckBox
{
    private readonly string name;
    private readonly bool value;

    public CheckBox(string name, bool value)
    {
        this.name = name;
        this.value = value;
    }

    public override string ToString()
    {
        var valueStr = value ? "Active" : "DeActive";
        return $"{name} is {valueStr}";
    }
}