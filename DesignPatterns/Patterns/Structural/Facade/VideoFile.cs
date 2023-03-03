namespace DesignPatterns.Patterns.Structural.Facade;

public class VideoFile
{
    private readonly string _fileName;
    private readonly string _ext;

    public VideoFile(string path)
    {
        _fileName = Path.GetFileName(path);
        _ext = Path.GetExtension(path);
    }

    public string GetFileName() => _fileName;
    public string GetExtension() => _ext;
}