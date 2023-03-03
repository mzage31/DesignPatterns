namespace DesignPatterns.Patterns.Structural.Proxy;

public class ProxyImage : IImage
{
    private readonly string _path;
    private IImage? image;

    public ProxyImage(string path)
    {
        _path = path;
    }

    public string Display()
    {
        image ??= new Image(_path);
        return image.Display();
    }
}