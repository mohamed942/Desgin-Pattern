namespace State_Pattern;

public class OutOfStockState : IState
{
    public void handleRequest()
    {
        Console.WriteLine("Out of stock state: Product unavailable,Please choose another product.");
    }
}

