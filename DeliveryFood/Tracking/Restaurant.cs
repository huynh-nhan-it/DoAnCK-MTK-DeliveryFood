using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.Tracking
{
    public class Restaurant : FoodDelivery
    {
        public Restaurant(bool image, string deliveryStatus)
            : base(image, deliveryStatus) { }
    }
}
