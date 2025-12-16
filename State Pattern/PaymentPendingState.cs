namespace State_Pattern;

public class PaymentPendingState : IState
{
    public void handleRequest()
    {
        Console.WriteLine("Payment pending state: Dispensing product.");
    }
}

