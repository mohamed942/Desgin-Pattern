namespace DecoratePattern;

public abstract class CoffeeDecorator : ICoffee
{
    private ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}
