namespace CompositePattern;

public class File : IFileSystemComponent
{
    public string Name { get; set; }
    public decimal Size { get; set; }
    public File(string name, decimal size) => (Name, Size) = (name, size);
   public void Display()
    {
        Console.WriteLine($"File Name : {Name} and Size : {Size} bytes");
    }
}
