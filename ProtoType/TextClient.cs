namespace ProtoType;

public class TextClient
{
    public TextClient(IDocumentPrototype textDocument)
    {
        TextDocument = textDocument;
    }

    public IDocumentPrototype TextDocument { get; set; }
    public IDocumentPrototype TextDocumentClone => TextDocument.Clone();
}

