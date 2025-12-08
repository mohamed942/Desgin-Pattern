namespace FactoryMethod;

public class Circle : Shape
{

    public Circle():base(ShapeType.Circle)
    {
        Generete();
    }

    public override void Generete()
    {
        Console.WriteLine("Circle");
    }
}

