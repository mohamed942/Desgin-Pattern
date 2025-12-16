namespace State_Pattern;


public interface IVendingMachineState
{
    public void handleRequest();
}

public class ReadyState : IVendingMachineState
{
    public void handleRequest()
    {
        Console.WriteLine("Ready state: Please select a product.");
    }
}

public class ProductSelectedState : IVendingMachineState
{
    public void handleRequest()
    {
        Console.WriteLine("Product selected state: Processing payment.");
    }
}

public class PaymentPendingState : IVendingMachineState
{
    public void handleRequest()
    {
        Console.WriteLine("Payment pending state: Dispensing product.");
    }
}

public class OutOfStockState : IVendingMachineState
{
    public void handleRequest()
    {
        Console.WriteLine("Out of stock state: Product unavailable,Please choose another product.");
    }
}

public class VendingMachine
{
    private IVendingMachineState _state;
    public VendingMachine()
    {
        _state = new ReadyState();
    }
    public void setState(IVendingMachineState state)
    {
        _state = state;
    }
    public void request()
    {
        _state.handleRequest();
    }
}

