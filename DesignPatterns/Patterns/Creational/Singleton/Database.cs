namespace DesignPatterns.Patterns.Creational.Singleton;

public class Database
{
    private static Database? _instance;
    public static Database Instance => _instance ??= new Database();
    public static Database GetInstance()
    {
        if (_instance != null)
            return _instance;
        _instance = new Database();
        return _instance;
    }

    public string Query()
    {
        return "Some Data";
    }
}