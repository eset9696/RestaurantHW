using RestaurantHW.Models;

namespace RestaurantHW.Services.Implementations
{
    public class MenuRestaurantService : IMenuRestaurantService
    {
        public List<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>() 
            {
                new MenuItem(0, "Филеменьон", "Стейк из говяжей вырезки породы BlackAngus", 30, 200),
                new MenuItem(1, "Стейк рибай", "Нарезается из отруба говядины толстый край с 6 по 12 ребро", 25, 300),
                new MenuItem(2, "Свиные ребрышки", "Свиные ребрышки сваренные в сувиде с барбекю соусом", 10, 350)
            };
        }
    }
}
