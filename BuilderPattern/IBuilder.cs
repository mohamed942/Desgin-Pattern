namespace BuilderPattern;

public interface IBuilder
{
    public void BuildCPU();
    public void BuildGPU();
    public void BuildRAM();
    public void BuildStorage();
    public Cpmputer GetComputer();
}
