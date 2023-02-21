namespace DesignPatterns.Patterns.Builder;

public interface IPizzaBuilder<out T>
{
    IPizzaBuilder<T> Reset();
    IPizzaBuilder<T> AddPepperoni();
    IPizzaBuilder<T> AddPepper();
    IPizzaBuilder<T> AddChicken();
    T Build();
}