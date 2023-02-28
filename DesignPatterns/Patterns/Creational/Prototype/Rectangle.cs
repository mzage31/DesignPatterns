namespace DesignPatterns.Patterns.Creational.Prototype;

public class Rectangle : Shape<Rectangle>
{
    public int Width { get; set;  }
    public int Height { get; set; }
    private int calculatedArea;

    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(Rectangle shape) : base(shape)
    {
        Width = shape.Width;
        Height = shape.Height;
        calculatedArea = shape.calculatedArea;
    }

    public void CalculateArea()
    {
        calculatedArea = Width * Height;
    }

    public override Rectangle Clone()
    {
        return new Rectangle(this);
    }

    public override string ToString()
    {
        return $"A Rectangle positioned at ({X}, {Y}) with the size of {Width}x{Height}. Calculated area is {calculatedArea}";
    }
}