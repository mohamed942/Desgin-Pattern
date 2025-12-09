namespace SingletonPattern;

public class Singleton 
{ 
    private static Singleton? instance;
    private static readonly object _lock = new object();

    private static Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
    private Singleton() { }
    public static Singleton GetInstanceOneCheck()
    {
        if (instance == null)
        {
            if(instance == null)
                instance = new Singleton();
        }
        return instance;
    }

    public static Singleton GetInstanceTwoCheck()
    {
        if (instance == null)
        {
            lock (_lock)
            {
                if (instance != null)
                    return instance;
                instance = new Singleton();
            }
            
        }
        return instance;
    }

    public static Singleton GetInstanceByLazy()
    {
        return lazy.Value;
    }

}