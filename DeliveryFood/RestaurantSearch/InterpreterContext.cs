using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantSearch
{
    public class InterpreterContext
    {
        private readonly RestaurantService restaurantService;

        public InterpreterContext(String endpoint)
        {
            restaurantService = new RestaurantService(endpoint);
        }

        public List<RestaurantModel> GetAllRestaurants()
        {
            return restaurantService.GetAllRestaurants();
        }
    }
}
