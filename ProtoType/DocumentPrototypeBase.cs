namespace ProtoType;

// Base implementation that provides a shallow clone using MemberwiseClone.
// Concrete prototypes can override Clone when a deep copy is needed.
public abstract class DocumentPrototypeBase : IDocumentPrototype
{
    public virtual IDocumentPrototype Clone()
    {
        return (IDocumentPrototype)MemberwiseClone();
    }

    public abstract string Display();
}

