namespace DesignPatterns.Patterns.Behavioral.Command;

public class Button
{
    public Button()
    {
        OnClick = (_, _) => { };
    }

    public event EventHandler OnClick;

    public void Click(object obj, EventArgs args)
    {
        OnClick?.Invoke(obj, args);
    }
}