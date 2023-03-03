using System.Drawing;

namespace DesignPatterns.Patterns.Structural.Flyweight;

public class ParticleData
{
    public ParticleData(string hugeData, Color color)
    {
        HugeData = hugeData;
        Color = color;
    }
    public string HugeData { get; }
    public Color Color { get; }

    public static int GetMemorySize()
    {
        // imagine huge data storing 20 kilo bytes and color storing 4 bytes
        return 20000 + 4;
    }
}