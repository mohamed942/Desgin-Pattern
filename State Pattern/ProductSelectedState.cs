namespace State_Pattern;

public class ProductSelectedState : IState
{
    public void handleRequest()
    {
        Console.WriteLine("Product selected state: Processing payment.");
    }
}

