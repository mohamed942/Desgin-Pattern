namespace AbstracFactory;

public class NorthAmericanCarFactory : CarFactory
{
    public Car CreateCar()
    {
        return new SedanCar();
    }
    public CarSpecification CreateCarSpecification()
    {
        return new NorthAmericanCarSpecification();
    }
}


