namespace CommandPattern;

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
