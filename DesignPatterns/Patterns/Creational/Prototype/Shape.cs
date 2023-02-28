namespace DesignPatterns.Patterns.Creational.Prototype;

public abstract class Shape<T> where T : Shape<T>
{
    public int X { get; set; }
    public int Y { get; set; }

    protected Shape(int x, int y)
    {
        X = x;
        Y = y;
    }

    protected Shape(Shape<T> shape)
    {
        X = shape.X;
        Y = shape.Y;
    }

    public abstract Shape<T> Clone();

    public override string ToString()
    {
        return $"A shape positioned at ({X}, {Y})";
    }
}