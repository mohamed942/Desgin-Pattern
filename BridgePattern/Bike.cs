namespace BridgePattern;
public class Bike : Vehicle
{
    public Bike(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
    {
    }

    public override void manufacture()
    {
        Console.WriteLine("Bike");
        workshop1?.work();
        workshop2?.work();
    }
}
