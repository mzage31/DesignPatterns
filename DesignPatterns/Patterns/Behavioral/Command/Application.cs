namespace DesignPatterns.Patterns.Behavioral.Command;

public class Application
{
    public string ClipBoard { get; set; }
    private readonly Shortcuts shortcuts;
    private readonly CommandHistory commandHistory;
    private readonly Editor editor;
    public readonly Button CopyButton;
    public readonly Button CutButton;
    public readonly Button PasteButton;
    public readonly Button UndoButton;

    public Application()
    {
        ClipBoard = string.Empty;
        editor = new Editor();
        commandHistory = new CommandHistory();
        shortcuts = new Shortcuts();
        CopyButton = new Button();
        CutButton = new Button();
        PasteButton = new Button();
        UndoButton = new Button();
    }

    public Editor BindEditor()
    {
        CopyButton.OnClick += (_, _) => ExecuteCommand(new CopyCommand(this, editor));
        CutButton.OnClick += (_, _) => ExecuteCommand(new CutCommand(this, editor));
        PasteButton.OnClick += (_, _) => ExecuteCommand(new PasteCommand(this, editor));
        UndoButton.OnClick += (_, _) => ExecuteCommand(new UndoCommand(this, editor));

        shortcuts.Add("ctrl+c", () => ExecuteCommand(new CopyCommand(this, editor)));
        shortcuts.Add("ctrl+x", () => ExecuteCommand(new CutCommand(this, editor)));
        shortcuts.Add("ctrl+v", () => ExecuteCommand(new PasteCommand(this, editor)));
        shortcuts.Add("ctrl+z", () => ExecuteCommand(new UndoCommand(this, editor)));
        return editor;
    }

    public void ExecuteShortcut(string shortcut)
    {
        shortcuts.Execute(shortcut);
    }

    private void ExecuteCommand(Command command)
    {
        if (command.Execute())
            commandHistory.Push(command);
    }

    public void Undo()
    {
        commandHistory.Pop()?.Undo();
    }
}