namespace DesignPatterns.Patterns.Structural.Composite;

public class CompoundGraphics : IGraphics
{
    private List<IGraphics> Children { get; set; }

    public CompoundGraphics(params IGraphics[] graphics)
    {
        Children = new List<IGraphics>(graphics);
    }

    public void Move(float x, float y)
    {
        foreach (var child in Children)
            child.Move(x, y);
    }

    public string Draw()
    {
        var sb = Children.Select(child => child.Draw()).ToList();
        return $"Compound[{string.Join(", ", sb)}]";
    }
}