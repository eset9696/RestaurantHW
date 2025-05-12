using Microsoft.AspNetCore.Mvc;

namespace RestaurantHW.Services.Implementations
{
    public class RestaurantAddressesService : IRestaurantAddressesService
    {
        public List<string> GetAddress()
        {
            return new List<string> { 
                "город Москва, улица Ленина, дом 33",
                "город Иркутск, улица Дзержинского, дом 20",
                "город Новосибирск, улица Горького, дом 17"
            };
        }
    }
}
