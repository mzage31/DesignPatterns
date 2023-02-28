namespace DesignPatterns.Patterns.Creational.Prototype;

public class Circle : Shape<Circle>
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius) : base(x, y)
    {
        Radius = radius;
    }

    public Circle(Circle shape) : base(shape)
    {
        Radius = shape.Radius;
    }

    public override Circle Clone()
    {
        return new Circle(this);
    }

    public override string ToString()
    {
        return $"A Circle positioned at ({X}, {Y}) with the radius of {Radius}";
    }
}