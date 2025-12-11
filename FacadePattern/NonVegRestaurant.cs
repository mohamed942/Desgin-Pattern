namespace FacadePattern;

public class NonVegRestaurant : IHotle
{
    public Menu GetMenu()
    {
        Menu menu = new Menu();
        menu.Foods.Add(new Food() { Name = "Chicken Biryani", Price = 120 });
        menu.Foods.Add(new Food() { Name = "Chicken Butter Masala", Price = 150 });
        return menu;
    }
}
