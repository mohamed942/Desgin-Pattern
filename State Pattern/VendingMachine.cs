namespace State_Pattern;

public class VendingMachine
{
    private IState _state;
    public VendingMachine()
    {
        _state = new ReadyState();
    }
    public void setState(IState state)
    {
        _state = state;
    }
    public void request()
    {
        _state.handleRequest();
    }
}

