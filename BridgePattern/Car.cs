namespace BridgePattern;

public class Car : Vehicle
{
    public Car(IWorkshop workshop1, IWorkshop workshop2) : base(workshop1, workshop2)
    {
    }

    public override void manufacture()
    {
        Console.WriteLine("Car");
        workshop1?.work();
        workshop2?.work();
    }
}
