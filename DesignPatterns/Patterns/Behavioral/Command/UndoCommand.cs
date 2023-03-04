namespace DesignPatterns.Patterns.Behavioral.Command;

public class UndoCommand : Command
{
    public UndoCommand(Application application, Editor editor) : base(application, editor)
    {
    }

    public override bool Execute()
    {
        Application.Undo();
        return false;
    }
}