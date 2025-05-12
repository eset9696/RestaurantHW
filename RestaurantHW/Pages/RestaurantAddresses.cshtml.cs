using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantHW.Services;

namespace RestaurantHW.Pages
{
    public class RestaurantAddressesModel : PageModel
    {
        private readonly IRestaurantAddressesService _addresses;
        public List<string>? Restaurants {get; private set;}

        public RestaurantAddressesModel(IRestaurantAddressesService addresses)
        {
            _addresses = addresses;
        }
        public void OnGet()
        {
            Restaurants = _addresses.GetAddress();
        }
    }
}
