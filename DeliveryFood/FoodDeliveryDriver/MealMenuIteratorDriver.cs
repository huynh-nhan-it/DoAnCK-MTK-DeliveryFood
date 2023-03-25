using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.RestaurantFoodMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodDeliveryDriver
{
    public class MealMenuIteratorDriver
    {
  
        public void PrintMealMenu(string restaurantId, Restaurants restaurants, string location, List<CartModel> list_order, UserModel userModel)
        {
            restaurants.Hide();
            Waitress waitress = new Waitress(restaurantId);
            var foodMenu = waitress.PrintFoodMenu();
            new Menu(foodMenu, location, list_order, userModel).Show();
        }
    }
}
