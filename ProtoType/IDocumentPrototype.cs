namespace ProtoType;

// Interface for the prototype
public interface IDocumentPrototype
{
    IDocumentPrototype Clone();
    string Display();
}

