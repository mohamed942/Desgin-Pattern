namespace CompositePattern;

public class Folder : IFileSystemComponent
{
    public string Name { get; set; }
    public List<IFileSystemComponent> Components { get; set; } = new List<IFileSystemComponent>();
    public Folder(string name) => Name = name;
   public void Display()
    {
        Console.WriteLine($"Folder Name : {Name}");
        foreach (var item in Components)
        {
            item.Display();
        }
    }
    public void Add(IFileSystemComponent component) => Components.Add(component);
}
