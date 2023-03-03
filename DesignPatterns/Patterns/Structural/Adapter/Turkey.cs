namespace DesignPatterns.Patterns.Structural.Adapter;

public class Turkey : ITurkey
{
    public string Gobble()
    {
        return "Gobble Gobble Gobble";
    }

    public string Fly()
    {
        return "Flies 100 meters";
    }
}