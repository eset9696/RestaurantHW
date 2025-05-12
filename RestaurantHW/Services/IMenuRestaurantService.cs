using RestaurantHW.Models;

namespace RestaurantHW.Services
{
    public interface IMenuRestaurantService
    {
        List<MenuItem> GetMenuItems();
    }
}
