namespace DesignPatterns.Patterns.Creational.Builder;

public interface IPizzaDirector<out T>
{
    public T MakePepperoniPizza();
    public T MakeChickenPizza();
}