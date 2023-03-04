namespace DesignPatterns.Patterns.Behavioral.Command;

public class Editor
{
    public string Text { get; set; }
    private int selectionStart;
    private int selectionEnd;

    public Editor()
    {
        Text = string.Empty;
        selectionStart = 0;
        selectionEnd = 0;
    }

    public void SetSelection(int start, int end)
    {
        selectionStart = start;
        selectionEnd = end;
    }

    public void SetCursor(int index)
    {
        selectionStart = index;
        selectionEnd = index;
    }

    public string GetSelection()
    {
        return Text[selectionStart..selectionEnd];
    }

    public void DeleteSelection()
    {
        Text = Text[..selectionStart] + Text[selectionEnd..];
    }

    public void ReplaceSelection(string text)
    {
        Text = Text[..selectionStart] + text + Text[selectionEnd..];
    }
}