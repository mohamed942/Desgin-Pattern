namespace DecoratePattern;

public class ChocolateCoffee : CoffeeDecorator
{
    public ChocolateCoffee(ICoffee coffee) : base(coffee) { }
    public override string GetDescription()
    {
        return base.GetDescription() + " + Chocolate";
    }
    public override double GetCost()
    {
        return base.GetCost() + 1.0;
    }
}
