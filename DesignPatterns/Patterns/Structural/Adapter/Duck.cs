namespace DesignPatterns.Patterns.Structural.Adapter;

public class Duck : IDuck
{
    public string Quack()
    {
        return "Quack Quack Quack";
    }

    public string Fly()
    {
        return "Flies 500 meters";
    }
}