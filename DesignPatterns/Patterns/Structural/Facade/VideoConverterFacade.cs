namespace DesignPatterns.Patterns.Structural.Facade;

public class VideoConverterFacade
{
    public string Convert(string sourcePath, string targetPath)
    {
        var file = new VideoFile(sourcePath);
        var reader = new BitrateReader();
        var sourceCodec = CodecFactory.Extract(file); 
        var bitrateData = reader.Read(sourcePath, sourceCodec);

        ICodec targetCodec = Path.GetExtension(targetPath) switch
        {
            ".mp4" => new Mp4Codec(),
            ".webm" => new WebMCodec(),
            _ => throw new Exception("Codec not found")
        };

        var result = reader.Write(targetPath, bitrateData, targetCodec);
        return result;
    }
}