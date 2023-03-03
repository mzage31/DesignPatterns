namespace DesignPatterns.Patterns.Structural.Facade;

public class BitrateReader
{
    public string Read(string path, ICodec codec) => $"Read data from {path} with the {codec.GetCodecName()} codec";
    public string Write(string path, string data, ICodec codec) => $"Wrote \"{data}\" into {path} with the {codec.GetCodecName()} codec";
}