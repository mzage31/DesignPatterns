namespace DesignPatterns.Patterns.Behavioral.Command;

public class Shortcuts
{
    private readonly Dictionary<string, Action> shortcuts;

    public Shortcuts()
    {
        shortcuts = new Dictionary<string, Action>();
    }

    public void Add(string shortcut, Action action)
    {
        shortcuts.Add(shortcut, action);
    }

    public void Execute(string shortcut)
    {
        if (shortcuts.TryGetValue(shortcut, out var action))
            action();
    }
}