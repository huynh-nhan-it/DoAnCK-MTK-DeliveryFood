using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodBuilding
{
    public class MealBuilder
    {
        public Meal meal;
        public void PrepareMeal(List<CartModel> foodMenu)
        {
            meal = new Meal();
            meal.AddFoodItem(foodMenu);
        }
    }
}

