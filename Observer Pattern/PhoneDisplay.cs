namespace Observer_Pattern;

public class PhoneDisplay : IObserver
{
    public void update(string weather)
    {
        Console.WriteLine($"Phone Display: Weather updated to {weather}");
    }
}



