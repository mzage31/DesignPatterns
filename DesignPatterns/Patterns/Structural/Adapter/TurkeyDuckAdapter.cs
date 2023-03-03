namespace DesignPatterns.Patterns.Structural.Adapter;

public class TurkeyDuckAdapter : IDuck
{
    private readonly ITurkey _turkey;

    public TurkeyDuckAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }

    public string Quack()
    {
        return _turkey.Gobble();
    }

    public string Fly()
    {
        var v = new List<string>();
        for (var i = 0; i < 5; i++)
        {
            v.Add($"[{_turkey.Fly()}]");
        }
        return string.Join(" [Resting] ", v);
    }
}