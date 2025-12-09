namespace BuilderPattern;

public class GamingComputerBuilder : IBuilder
{
    private Cpmputer _computer = new Cpmputer();

    public void BuildCPU()
    {
        _computer.SetCPU("RTX 3090");
    }

    public void BuildGPU()
    {
        _computer.SetGPU("RTX 3090");
    }

    public void BuildRAM()
    {
        _computer.SetRAM("32GB");
    }

    public void BuildStorage()
    {
        _computer.SetStorage("1TB SSD");
    }

    public Cpmputer GetComputer()
    {
        return _computer;
    }
}
