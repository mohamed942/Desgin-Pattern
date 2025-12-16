namespace State_Pattern;

public class ReadyState : IState
{
    public void handleRequest()
    {
        Console.WriteLine("Ready state: Please select a product.");
    }
}

