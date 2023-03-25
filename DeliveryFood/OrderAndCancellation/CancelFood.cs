using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.OrderAndCancellation
{
    public class CancelFood : IFoodOrderCommands
    {
        private readonly Food food;
        private string location;
        private Payment payment;
        private UserModel userModel;
        public CancelFood(Food food, string location, Payment payment, UserModel userModel)
        {
            this.food = food;
            this.location = location;
            this.payment = payment;
            this.userModel = userModel;
        }

        public void Execute()
        {
            food.CancelFood(location, payment, userModel);
        }
    }
}
