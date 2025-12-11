namespace FacadePattern;

public class RestaurantFacade
{
    VegRestaurant veg = new VegRestaurant();
    NonVegRestaurant nonveg = new NonVegRestaurant();
    BothRestaurant both = new BothRestaurant();
    public Menu GetVegMenu()
    {
        return veg.GetMenu();
    }
    public Menu GetNonVegMenu()
    {
        return nonveg.GetMenu();
    }
    public Menu GetBothMenu()
    {
        return both.GetMenu();
    }
}