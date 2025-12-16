namespace Chain_of_Responsibility_pattern;

public class Request
{
    Priority priority;
    public Request(Priority priority)
    {
        this.priority = priority;
    }

    public Priority GetPriority()
    {
        return priority;
    }
}
