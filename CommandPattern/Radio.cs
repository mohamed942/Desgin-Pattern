namespace CommandPattern;

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
