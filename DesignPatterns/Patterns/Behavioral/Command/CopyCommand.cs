namespace DesignPatterns.Patterns.Behavioral.Command;

public class CopyCommand : Command
{
    public CopyCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
        Application.ClipBoard = Editor.GetSelection();
        return false;
    }
}