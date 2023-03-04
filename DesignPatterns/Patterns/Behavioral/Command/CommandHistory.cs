namespace DesignPatterns.Patterns.Behavioral.Command;

public class CommandHistory
{
    private readonly Stack<Command> commands;

    public CommandHistory()
    {
        commands = new Stack<Command>();
    }

    public void Push(Command command) => commands.Push(command);

    public Command? Pop()
    {
        commands.TryPop(out var command);
        return command;
    }
}