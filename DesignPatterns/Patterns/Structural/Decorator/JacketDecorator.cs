namespace DesignPatterns.Patterns.Structural.Decorator;

public class JacketDecorator : BaseClothDecorator
{
    public JacketDecorator(IClothed clothed) : base(clothed)
    {
    }

    public override string WhatAreYouWearing()
    {
        return base.WhatAreYouWearing().Replace(" and ", ", ") + " and a jacket";
    }
}