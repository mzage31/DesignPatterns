namespace DesignPatterns.Patterns.Structural.Decorator;

public class PantsDecorator : BaseClothDecorator
{
    public PantsDecorator(IClothed clothed) : base(clothed)
    {
    }

    public override string WhatAreYouWearing()
    {
        return base.WhatAreYouWearing().Replace(" and ", ", ") + " and pants";
    }
}