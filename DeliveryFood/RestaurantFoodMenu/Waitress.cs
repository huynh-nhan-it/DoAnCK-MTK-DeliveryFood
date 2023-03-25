using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantFoodMenu
{
    public class Waitress
    {
        private readonly string restaurantId;
        FoodMenu foodMenu;
        public Waitress(string restaurantId)
        {
            this.restaurantId = restaurantId;
        }

        public List<FoodMenuModel> PrintFoodMenu()
        {
            foodMenu = new FoodMenu(restaurantId);
            IIterator restaurantFoodMenu = foodMenu.CreateFoodMenuIterator();
            return PrintFoodMenu(restaurantFoodMenu);
        }

        private List<FoodMenuModel> PrintFoodMenu(IIterator iterator)
        {
         
            List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();

            while (iterator.HasNext())
            {
                FoodMenuModel foodMenuItem = (FoodMenuModel)iterator.Next();
                foodMenu.Add(foodMenuItem);
            }
            return foodMenu;
        }
    }
}
