namespace ProtoType;

// Interface for the prototype
public interface IDocumentPrototype
{
    IDocumentPrototype Clone();
    string Display();
}

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

public class HtmlDocument : DocumentPrototypeBase
{
    public string Html { get; set; }

    public HtmlDocument(string html)
    {
        Html = html;
    }

    public override IDocumentPrototype Clone()
    {
        return (IDocumentPrototype)MemberwiseClone();
    }

    public override string Display()
    {
        return $"<html>{Html}</html>";
    }
}

public class TextClient
{
    public TextClient(IDocumentPrototype textDocument)
    {
        TextDocument = textDocument;
    }

    public IDocumentPrototype TextDocument { get; set; }
    public IDocumentPrototype TextDocumentClone => TextDocument.Clone();
}

public class HtmlClient
{
    public HtmlClient(IDocumentPrototype htmlDocument)
    {
        HtmlDocument = htmlDocument;
    }

    public IDocumentPrototype HtmlDocument { get; set; }
    public IDocumentPrototype HtmlDocumentClone => HtmlDocument.Clone();
}

