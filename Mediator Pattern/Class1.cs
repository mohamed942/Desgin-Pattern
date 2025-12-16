namespace Mediator_Pattern;

public interface AirTrafficControlTower
{
    public void TakeOff(Airplane airplane);
    public void Land();
}

public class AirportControlTower : AirTrafficControlTower
{
    public void TakeOff(Airplane airplane)
    {
        Console.WriteLine("Airplane is taking off");
    }
    public void Land()
    {
        Console.WriteLine("Airplane is landing");
    }
}

public interface Airplane
{
    public void TakeOff();
    public void Land();

    public string SendMessage(string message);
}

public class CommercialAirplane : Airplane
{
    AirTrafficControlTower tower;
    public CommercialAirplane(AirTrafficControlTower tower) {
        this.tower = tower;
    }
    public void TakeOff()
    {
        tower.TakeOff(this);
        
    }
    public void Land()
    {
        tower.Land();
    }
    public string SendMessage(string message)
    {
        return message;
    }
}