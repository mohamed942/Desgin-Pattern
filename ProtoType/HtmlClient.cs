namespace ProtoType;

public class HtmlClient
{
    public HtmlClient(IDocumentPrototype htmlDocument)
    {
        HtmlDocument = htmlDocument;
    }

    public IDocumentPrototype HtmlDocument { get; set; }
    public IDocumentPrototype HtmlDocumentClone => HtmlDocument.Clone();
}

