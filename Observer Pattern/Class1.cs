namespace Observer_Pattern;

// Subject inerface , concrete subject , observer interface , Concrete observer

public interface ISubject
{
    void addObserver(IObserver o);
    void removeObserver(IObserver o);
    void notifyObserver();
}

public class WeatherStation : ISubject
{
    private string weather = "";
    List<IObserver> observers = new List<IObserver>();
    public void addObserver(IObserver o)
    {
        observers.Add(o);
    }
    public void removeObserver(IObserver o)
    {
        observers.Remove(o);
    }
    public void notifyObserver()
    {
        foreach (IObserver o in observers)
        {
            o.update(weather);
        }
    }
}
public interface IObserver
{
    void update(string weather);
}
public class PhoneDisplay : IObserver
{
    public void update(string weather)
    {
        Console.WriteLine($"Phone Display: Weather updated to {weather}");
    }
}
public class TVDisplay : IObserver
{
    public void update(string weather)
    {
        Console.WriteLine($"TV Display: Weather updated to {weather}");
    }
}



