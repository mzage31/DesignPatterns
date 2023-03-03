namespace DesignPatterns.Patterns.Structural.Decorator;

public class BaseClothDecorator : IClothed
{
    private readonly IClothed _clothed;

    public BaseClothDecorator(IClothed clothed)
    {
        _clothed = clothed;
    }
    
    public virtual string WhatAreYouWearing()
    {
        return _clothed.WhatAreYouWearing();
    }
}