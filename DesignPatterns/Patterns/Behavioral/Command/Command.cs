namespace DesignPatterns.Patterns.Behavioral.Command;

public abstract class Command
{
    protected readonly Application Application;
    protected readonly Editor Editor;
    private string backup;

    protected Command(Application application, Editor editor)
    {
        Application = application;
        Editor = editor;
        backup = string.Empty;
    }

    protected void SaveBackup()
    {
        backup = Editor.Text;
    }

    public void Undo()
    {
        Editor.Text = backup;
    }

    public abstract bool Execute();
}