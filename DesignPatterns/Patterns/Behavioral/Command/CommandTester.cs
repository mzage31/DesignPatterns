using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Behavioral.Command;

public class CommandTester : PatternTester
{
    public CommandTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "Command Pattern";

    protected override void TestImplementation()
    {
        var application = new Application();
        var editor = application.BindEditor();
        editor.Text = "Hello this is a simple text";

        editor.SetSelection(16, 22);
        application.CopyButton.Click(this, EventArgs.Empty);
        var afterCopy = editor.Text;

        editor.SetSelection(6, 10);
        application.PasteButton.Click(this, EventArgs.Empty);
        var afterPaste = editor.Text;

        application.ExecuteShortcut("ctrl+z");
        var afterUndo = editor.Text;
        
        
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("After Copy", afterCopy)
                .AddRow("After Paste", afterPaste)
                .AddRow("After Undo", afterUndo)
                .ToMarkDownString()
        );
    }
}