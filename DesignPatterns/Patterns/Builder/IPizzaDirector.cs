namespace DesignPatterns.Patterns.Builder;

public interface IPizzaDirector<out T>
{
    public T MakePepperoniPizza();
    public T MakeChickenPizza();
}