namespace DesignPatterns.Patterns.Builder;

public class PizzaDescriptor
{
    public class Builder : IPizzaBuilder<PizzaDescriptor>
    {
        private PizzaDescriptor pizza = null!;

        public Builder()
        {
            Reset();
        }
        
        public IPizzaBuilder<PizzaDescriptor> Reset()
        {
            pizza = new PizzaDescriptor();
            return this;
        }

        public IPizzaBuilder<PizzaDescriptor> AddPepperoni()
        {
            pizza.hasPepperoni = true;
            return this;
        }

        public IPizzaBuilder<PizzaDescriptor> AddPepper()
        {
            pizza.hasPepper = true;
            return this;
        }

        public IPizzaBuilder<PizzaDescriptor> AddChicken()
        {
            pizza.hasChicken = true;
            return this;
        }

        public PizzaDescriptor Build()
        {
            var final = pizza;
            Reset();
            return final;
        }
    }
    
    public class Director : IPizzaDirector<PizzaDescriptor>
    {
        private readonly IPizzaBuilder<PizzaDescriptor> builder;

        public Director(IPizzaBuilder<PizzaDescriptor> builder)
        {
            this.builder = builder;
        }
        
        public PizzaDescriptor MakePepperoniPizza()
        {
            return builder
                .AddPepperoni()
                .AddPepper()
                .Build();
        }

        public PizzaDescriptor MakeChickenPizza()
        {
            return builder
                .AddChicken()
                .Build();
        }
    }


    
    private bool hasPepperoni;
    private bool hasPepper;
    private bool hasChicken;

    public override string ToString()
    {
        var list = new List<string>();
        
        if(hasPepperoni)
            list.Add("tasty pepperoni");
        if(hasPepper)
            list.Add("full of pepper");
        if(hasChicken)
            list.Add("juicy chicken");

        return $"A {string.Join(", ", list)} pizza";
    }
}