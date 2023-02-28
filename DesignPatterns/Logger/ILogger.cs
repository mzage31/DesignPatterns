namespace DesignPatterns.Logger;

public interface ILogger
{
    void Log(string message);
    void LogLine(string message);
    void Display();
}