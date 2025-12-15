namespace CommandPattern;

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

public class Television : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Television is turned ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Television is turned OFF");
    }

    public void ChangeChannel(int channel)
    {
        Console.WriteLine($"Television channel changed to {channel}");
    }
}

public class Radio : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Radio is turned ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Radio is turned OFF");
    }

    public void SetFrequency(double frequency)
    {
        Console.WriteLine($"Radio Frequency changed to {frequency}");
    }
}
public interface ICommand
{
    void Execute();
}

public class TurnOnCommand : ICommand
{
    private readonly IDevice _device;
    public TurnOnCommand(IDevice device)
    {
        _device = device;
    }
    public void Execute()
    {
        _device.TurnOn();
    }
}
public class TurnOffCommand : ICommand
{
    private readonly IDevice _device;
    public TurnOffCommand(IDevice device)
    {
        _device = device;
    }
    public void Execute()
    {
        _device.TurnOff();
    }
}

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

public class SetFrequencyCommand : ICommand
{
    private readonly Radio _radio;
    private readonly double _frequency;
    public SetFrequencyCommand(Radio radio, double frequency)
    {
        _radio = radio;
        _frequency = frequency;
    }
    public void Execute()
    {
        _radio.SetFrequency(_frequency);
    }
}

public class RomoteControl
{
    private  ICommand? _command;
    public void AddCommand(ICommand command)
    {
        _command = command;
    }
    public void ExecuteCommands()
    {
        
        _command?.Execute();
        
    }
}
