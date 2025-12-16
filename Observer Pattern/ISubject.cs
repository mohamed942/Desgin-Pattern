namespace Observer_Pattern;

// Subject inerface , concrete subject , observer interface , Concrete observer

public interface ISubject
{
    void addObserver(IObserver o);
    void removeObserver(IObserver o);
    void notifyObserver();
}



