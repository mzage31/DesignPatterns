using System.Drawing;

namespace DesignPatterns.Patterns.Structural.Flyweight;

public class ParticleDataFactory
{
    private readonly List<ParticleData> _cache;

    public ParticleDataFactory()
    {
        _cache = new List<ParticleData>();
    }

    public int CacheCount => _cache.Count;

    public ParticleData GetParticleData(string hugeData, Color color)
    {
        var data = _cache.FirstOrDefault(c => c.HugeData == hugeData && c.Color == color);
        if (data != null)
            return data;
        data = new ParticleData(hugeData, color);
        _cache.Add(data);
        return data;
    }
}