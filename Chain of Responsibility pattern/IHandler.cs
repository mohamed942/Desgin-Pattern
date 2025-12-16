namespace Chain_of_Responsibility_pattern;

public interface IHandler
{
    void setNext(IHandler handler);
    void handleRequest(Request request);
}
