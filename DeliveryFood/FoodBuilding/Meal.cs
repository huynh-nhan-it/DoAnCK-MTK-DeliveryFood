using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodBuilding
{
    public class Meal
    {
        private readonly List<CartModel> foodItems = new List<CartModel>();

        public void AddFoodItem(List<CartModel> items)
        {
            foodItems.AddRange(items);
        }

        public double GetCost()
        {
            double cost = 0;

            foreach (var item in foodItems)
            {
                cost += item.Food.Rate * item.Quantity;
            }

            return cost;
        }

        public List<CartModel> ShowItems()
        {
            return foodItems;
        }
    }
}
