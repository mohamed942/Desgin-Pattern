namespace FacadePattern;

public class VegRestaurant : IHotle
{
    public Menu GetMenu()
    {
        Menu menu = new Menu();
        menu.Foods.Add(new Food() { Name = "Veg Biryani", Price = 120 });
        menu.Foods.Add(new Food() { Name = "Paneer Butter Masala", Price = 150 });
        return menu;
    }
}
