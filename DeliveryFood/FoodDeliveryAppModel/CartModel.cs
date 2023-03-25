using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.FoodDeliveryAppModel
{
    public class CartModel
    {
        private FoodMenuModel food;
        private int quantity;

        public CartModel(FoodMenuModel food, int quantity){
            this.food = food;
            this.quantity = quantity;
        }

        public FoodMenuModel Food
        {
            get { return food; }
            set { food = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
