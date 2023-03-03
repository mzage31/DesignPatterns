namespace DesignPatterns.Patterns.Structural.Proxy;

public class Image : IImage
{
    private readonly string _path;

    public Image(string path)
    {
        _path = path;
        // load image from file
    }

    public string Display()
    {
        return $"Showing {_path}";
    }
}