namespace DesignPatterns.Patterns.Behavioral.Command;

public class PasteCommand : Command
{
    public PasteCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
        SaveBackup();
        Editor.ReplaceSelection(Application.ClipBoard);
        return true;
    }
}