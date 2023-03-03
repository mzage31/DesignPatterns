namespace DesignPatterns.Patterns.Structural.Decorator;

public class ShirtDecorator : BaseClothDecorator
{
    public ShirtDecorator(IClothed clothed) : base(clothed)
    {
    }

    public override string WhatAreYouWearing()
    {
        return base.WhatAreYouWearing().Replace(" and ", ", ") + " and a shirt";
    }
}