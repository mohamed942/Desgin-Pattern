namespace BuilderPattern;

public class Director
{
    public void Construct(IBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }
}
