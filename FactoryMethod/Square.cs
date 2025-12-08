namespace FactoryMethod;

public class Square : Shape
{
    public Square() : base(ShapeType.Square)
    {
        Generete();
    }

    public override void Generete()
    {
        Console.WriteLine("Square");
    }
}

