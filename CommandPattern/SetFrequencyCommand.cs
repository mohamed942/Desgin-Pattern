namespace CommandPattern;

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
