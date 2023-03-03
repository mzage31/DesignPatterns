using System.Drawing;
using System.Globalization;
using ConsoleTables;
using DesignPatterns.Logger;

namespace DesignPatterns.Patterns.Structural.Flyweight;

public class FlyWeightTester : PatternTester
{
    public FlyWeightTester(ILogger logger) : base(logger)
    {
    }

    protected override string GetName() => "FlyWeight Pattern";

    protected override void TestImplementation()
    {
        var factory = new ParticleDataFactory();

        var redParticles = new List<Particle>();
        for (var i = 0; i < 1000000; i++)
            redParticles.Add(new Particle(
                factory,
                Random.Shared.Next(-1000, 1000),
                Random.Shared.Next(-1000, 1000),
                "red-texture",
                Color.Red)
            );

        var blueParticles = new List<Particle>();
        for (var i = 0; i < 1000000; i++)
            blueParticles.Add(new Particle(
                factory,
                Random.Shared.Next(-1000, 1000),
                Random.Shared.Next(-1000, 1000),
                "blue-texture",
                Color.Blue)
            );

        float flyweightMemorySize = (redParticles.Count + blueParticles.Count) * Particle.GetMemorySize() + factory.CacheCount * ParticleData.GetMemorySize();
        float noFlyweightMemorySize = (redParticles.Count + blueParticles.Count) * (Particle.GetMemorySize() + ParticleData.GetMemorySize());
        flyweightMemorySize /= 1000000;
        noFlyweightMemorySize /= 1000000000;

        var numberFormatInfo = new NumberFormatInfo { NumberGroupSizes = new[] { 3 }, NumberGroupSeparator = "," };
        Logger.LogLine(
            new ConsoleTable("Expression", "Result")
                .AddRow("Red Particle Count", redParticles.Count)
                .AddRow("Blue Particle Count", blueParticles.Count)
                .AddRow("Particle Data Count", factory.CacheCount)
                .AddRow("Random Red Particle", redParticles[Random.Shared.Next(0, redParticles.Count)].Render())
                .AddRow("Random Blue Particle", blueParticles[Random.Shared.Next(0, blueParticles.Count)].Render())
                .AddRow("Total Size with FlyWeight", flyweightMemorySize.ToString("N", numberFormatInfo) + " MB")
                .AddRow("Total Size Without FlyWeight", noFlyweightMemorySize.ToString("N", numberFormatInfo) + " GB")
                .ToMarkDownString()
        );
    }
}