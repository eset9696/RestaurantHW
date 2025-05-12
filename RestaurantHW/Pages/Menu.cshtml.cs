using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantHW.Models;
using RestaurantHW.Services;

namespace RestaurantHW.Pages
{
    public class MenuModel : PageModel
    {
        private readonly IMenuRestaurantService _menuRestaurantService;

        public List<MenuItem>? Menu { get; private set; }

        public MenuModel(IMenuRestaurantService menuRestaurantService)
        {
            _menuRestaurantService = menuRestaurantService;
        }
        public void OnGet()
        {
            Menu = _menuRestaurantService.GetMenuItems();
        }
    }
}
