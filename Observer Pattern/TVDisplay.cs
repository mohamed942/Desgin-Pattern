namespace Observer_Pattern;

public class TVDisplay : IObserver
{
    public void update(string weather)
    {
        Console.WriteLine($"TV Display: Weather updated to {weather}");
    }
}



