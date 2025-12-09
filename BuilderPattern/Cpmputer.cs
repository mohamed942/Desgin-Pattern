namespace BuilderPattern;

public class Cpmputer
{
    private string CPU;
    private string GPU;
    private string RAM;
    private string Storage;
    public void SetCPU(string cpu)
    {
        CPU = cpu;
    }
    public void SetGPU(string gpu)
    {
        GPU = gpu;
    }
    public void SetRAM(string ram)
    {
        RAM = ram;
    }
    public void SetStorage(string storage)
    {
        Storage = storage;
    }
    public void DisplayConfiguration()
    {
        Console.WriteLine("Computer Configuration:");
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
    }

}
