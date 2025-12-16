namespace Chain_of_Responsibility_pattern;

public class Level1Support : IHandler
{

    IHandler? nextHandler;
    public void handleRequest(Request request)
    {
        if(request.GetPriority() == Priority.Level1)
        {
            Console.WriteLine("Level 1 Support handled the request.");
        }
        else if(nextHandler != null)
        {
            nextHandler?.handleRequest(request);
        }
    }

    public void setNext(IHandler handler)
    {
        nextHandler = handler;
    }
}
