namespace AbstracFactory;

public class EuropeanCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new Hatchback();
    }
    public CarSpecification CreateCarSpecification()
    {
        return new EuropeanCarSpecification();
    }
}


