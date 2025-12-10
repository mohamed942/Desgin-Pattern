namespace DecoratePattern;

public class MilkCoffee : CoffeeDecorator
{
    public MilkCoffee(ICoffee coffee) : base(coffee) { }
    public override string GetDescription()
    {
        return base.GetDescription() + " + Milk";
    }
    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}
