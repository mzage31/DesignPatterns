namespace DesignPatterns.Patterns.Structural.Facade;

public class CodecFactory
{
    public static ICodec Extract(VideoFile file)
    {
        if (file.GetExtension() == ".mp4")
            return new Mp4Codec();
        if (file.GetExtension() == ".webm")
            return new WebMCodec();
        throw new Exception("Codec not found");
    }
}