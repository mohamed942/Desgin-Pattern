namespace AdapterPattern;

// Target interface expected by the client
// This is the interface that the client expects
public interface ITarget
{
    void Request();
}

// Adaptee class
// This is the class that needs to be adapted
public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request from Adaptee");
    }
}

// Adapter class
// This is the class that adapts the Adaptee to the ITarget interface
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }
   

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}


