namespace ProtoType;

public class TextDocument : DocumentPrototypeBase
{
    public string Text { get; set; }

    public TextDocument(string text)
    {
        Text = text;
    }

    // For this simple document a shallow clone is enough because string is immutable.
    public override IDocumentPrototype Clone()
    {
        return (IDocumentPrototype)MemberwiseClone();
    }

    public override string Display()
    {
        return Text;
    }
}

