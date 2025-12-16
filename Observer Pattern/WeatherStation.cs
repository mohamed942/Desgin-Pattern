namespace Observer_Pattern;

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



