namespace DesignPatterns.Patterns.Structural.Facade;

public class Mp4Codec : ICodec
{
    public string GetCodecName() => "H264";
}