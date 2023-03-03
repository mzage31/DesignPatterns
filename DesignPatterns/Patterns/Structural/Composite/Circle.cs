namespace DesignPatterns.Patterns.Structural.Composite;

public class Circle : IGraphics
{
    private float X { get; set; }
    private float Y { get; set; }
    private float Radius { get; set; }

    public Circle(float x, float y, float radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public void SetRadius(float radius)
    {
        Radius = radius;
    }

    public void Move(float x, float y)
    {
        X += x;
        Y += y;
    }

    public string Draw()
    {
        return $"Circle[({X}, {Y}), {Radius}]";
    }
}