namespace ProtoType;

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

