namespace DesignPatterns.Patterns.Behavioral.Command;

public class CutCommand : Command
{
    public CutCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
        SaveBackup();
        Application.ClipBoard = Editor.GetSelection();
        Editor.DeleteSelection();
        return true;
    }
}