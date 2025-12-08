namespace FactoryMethod;

public class ShapeFactory
{
    public static  Shape? CreateShape( Enum shapeType)
    {
        switch (shapeType)
        {
            case ShapeType.Circle:
                return new Circle();
            case ShapeType.Square:
                return new Square();
            default:
                return null;
        }
    }
}

