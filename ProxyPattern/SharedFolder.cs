namespace ProxyPattern;

public class SharedFolder : ISharedFolder
{
    public void PerformRWOperations() 
    { 
        Console.WriteLine("Reading / Writing files in Shared Folder");
    }
}
