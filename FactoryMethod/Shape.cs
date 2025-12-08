using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace FactoryMethod;

public abstract class Shape
{
    public Enum? shapeType = null;

    public Shape( Enum shapeType)
    {
        this.shapeType = shapeType;
    }
    public abstract void Generete();
}

