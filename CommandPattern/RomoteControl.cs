namespace CommandPattern;

public class RomoteControl
{
    private  ICommand? _command;
    public void AddCommand(ICommand command)
    {
        _command = command;
    }
    public void ExecuteCommands()
    {
        
        _command?.Execute();
        
    }
}
