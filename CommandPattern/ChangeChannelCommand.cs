namespace CommandPattern;

public class ChangeChannelCommand : ICommand
{
    private readonly Television _television;
    private readonly int _channel;
    public ChangeChannelCommand(Television television, int channel)
    {
        _television = television;
        _channel = channel;
    }
    public void Execute()
    {
        _television.ChangeChannel(_channel);
    }
}
