using System.Drawing;

namespace DesignPatterns.Patterns.Structural.Flyweight;

public class Particle
{
    public int X { get; set; }
    public int Y { get; set; }
    private readonly ParticleData _data;

    public Particle(ParticleDataFactory factory, int x, int y, string hughData, Color color)
    {
        X = x;
        Y = y;
        _data = factory.GetParticleData(hughData, color);
    }

    public void Move(int x, int y)
    {
        X += x;
        Y += y;
    }

    public static int GetMemorySize()
    {
        return sizeof(int) * 2;
    }

    public string Render()
    {
        var color = _data.Color == Color.Red ? "red" : _data.Color == Color.Green ? "green" : _data.Color == Color.Blue ? "blue" : "uniquely colored";
        return $"A {color} particle at ({X}, {Y}) with data: {_data.HugeData}";
    }
}