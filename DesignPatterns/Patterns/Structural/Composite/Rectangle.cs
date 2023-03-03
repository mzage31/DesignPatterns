namespace DesignPatterns.Patterns.Structural.Composite;

public class Rectangle : IGraphics
{
    private float X { get; set; }
    private float Y { get; set; }
    private float Width { get; set; }
    private float Height { get; set; }

    public Rectangle(float x, float y, float width, float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public void SetDimensions(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public void Move(float x, float y)
    {
        X += x;
        Y += y;
    }

    public string Draw()
    {
        return $"Rectangle[({X}, {Y}), {Width}x{Height}]";
    }
}