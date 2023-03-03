namespace DesignPatterns.Patterns.Structural.Decorator;

public class ShoesDecorator : BaseClothDecorator
{
    public ShoesDecorator(IClothed clothed) : base(clothed)
    {
    }

    public override string WhatAreYouWearing()
    {
        return base.WhatAreYouWearing().Replace(" and ", ", ") + " and shoes";
    }
}