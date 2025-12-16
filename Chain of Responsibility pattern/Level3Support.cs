namespace Chain_of_Responsibility_pattern;

public class Level3Support : IHandler
{
    IHandler? nextHandler;
    public void handleRequest(Request request)
    {
        if (request.GetPriority() == Priority.Level3)
        {
            Console.WriteLine("Level 3 Support handled the request.");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("No one can handle the request.");
            
        }
    }

    public void setNext(IHandler handler)
    {
        
    }
}
