using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.OrderAndCancellation
{
    public class OrderFood : IFoodOrderCommands
    {
        private readonly Food food;
        private double totalCost;
        private UserModel User;
        private string OrderId;
        private string location;
        private Payment payment;
        public OrderFood(Food food, string OrderID, UserModel User, double totalCost, string location, Payment payment)
        {
            this.food = food;
            OrderId = OrderID;
            this.User = User;
            this.totalCost = totalCost;
            this.location = location;
            this.payment = payment;
        }

        public void Execute()
        {
            food.OrderFood(OrderId, User, totalCost, location, payment);
        }
    }
}
