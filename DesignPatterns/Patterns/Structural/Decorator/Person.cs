namespace DesignPatterns.Patterns.Structural.Decorator;

public class Person : IClothed
{
    public string WhatAreYouWearing()
    {
        return "I'm wearing shorts";
    }
}