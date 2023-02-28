using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Logger;

public class FileLogger : ILogger
{
    private readonly string _path;
    private readonly StringBuilder _builder;

    public FileLogger(string path)
    {
        _path = path;
        _builder = new StringBuilder();
    }
    
    public void Log(string message)
    {
        _builder.Append(message);
    }

    public void LogLine(string message)
    {
        _builder.AppendLine(message);
    }

    public void Display()
    {
        File.WriteAllText(_path, _builder.ToString());
        Process.Start("notepad.exe", _path);
    }
}