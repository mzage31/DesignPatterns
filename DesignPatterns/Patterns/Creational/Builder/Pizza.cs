namespace DesignPatterns.Patterns.Creational.Builder;

public class Pizza
{
    private bool hasChicken;
    private bool hasPepper;


    private bool hasPepperoni;

    public override string ToString()
    {
        var list = new List<string>();

        if (hasPepperoni)
            list.Add("pepperoni");
        if (hasPepper)
            list.Add("pepper");
        if (hasChicken)
            list.Add("chicken");

        return $"Pizza with {string.Join(", ", list)}";
    }

    public class Builder : IPizzaBuilder<Pizza>
    {
        private Pizza pizza = null!;

        public Builder()
        {
            Reset();
        }

        public IPizzaBuilder<Pizza> Reset()
        {
            pizza = new Pizza();
            return this;
        }

        public IPizzaBuilder<Pizza> AddPepperoni()
        {
            pizza.hasPepperoni = true;
            return this;
        }

        public IPizzaBuilder<Pizza> AddPepper()
        {
            pizza.hasPepper = true;
            return this;
        }

        public IPizzaBuilder<Pizza> AddChicken()
        {
            pizza.hasChicken = true;
            return this;
        }

        public Pizza Build()
        {
            var final = pizza;
            Reset();
            return final;
        }
    }

    public class Director : IPizzaDirector<Pizza>
    {
        private readonly IPizzaBuilder<Pizza> builder;

        public Director(IPizzaBuilder<Pizza> builder)
        {
            this.builder = builder;
        }

        public Pizza MakePepperoniPizza()
        {
            return builder
                .AddPepperoni()
                .AddPepper()
                .Build();
        }

        public Pizza MakeChickenPizza()
        {
            return builder
                .AddChicken()
                .Build();
        }
    }
}