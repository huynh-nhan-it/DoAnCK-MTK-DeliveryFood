using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.OrderAndCancellation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodDeliveryDriver
{
    public class MealOrderDriver
    {
        public void MealOrderByUser(bool command, string location, UserModel userModel, Payment payment, double total)
        { 
            if (command)
            {
                Random random = new Random();
                string orderID = "00" + random.Next(1, 100);
                Food food = new Food();
                OrderFood orderFood = new OrderFood(food, orderID, userModel, total, location, payment);
                Customer customer = new Customer();
                customer.TakeOrder(orderFood);
                customer.PlaceOrders();
            }
            else
            {
                Food food = new Food();
                CancelFood cancelOrder = new CancelFood(food, location, payment, userModel);
                Customer customer = new Customer();
                customer.TakeOrder(cancelOrder);
                customer.PlaceOrders();
            }
        }
    }
}
