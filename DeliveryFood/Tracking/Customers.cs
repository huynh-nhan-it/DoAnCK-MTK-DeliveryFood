using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.Tracking
{
    public class Customers : ICustomers
    {
        public string lable { get; set; }
        public bool image { get; set; }
        public Restaurant Restaurant { get; set; }

      

        public void Update(FoodDelivery foodDelivery)
        {
            lable = foodDelivery.DeliveryStatus;
            image = foodDelivery.image;
        }

    }
}
