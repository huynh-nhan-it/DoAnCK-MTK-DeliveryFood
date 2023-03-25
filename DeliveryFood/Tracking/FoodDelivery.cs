using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.Tracking
{
    public abstract class FoodDelivery
    {
        #region Properties

        private readonly List<ICustomers> _customers = new List<ICustomers>();

        public bool image { get; set; }


        private string deliveryStatus;
        public string DeliveryStatus
        {
            get { return deliveryStatus; }
            set
            {
                if (deliveryStatus != value)
                {
                    deliveryStatus = value; 
                    Notify();
                }
            }
        }



        #endregion

        #region Constructor

        protected FoodDelivery (bool image, string deliveryStatus)
        {
       
            this.image = image;
            this.deliveryStatus = deliveryStatus;
        }

        #endregion

        #region Methods

        public void Attach(ICustomers customer)
        {
            _customers.Add(customer);
        }

        public void Notify()
        {
            foreach (ICustomers customer in _customers)
            {
                customer.Update(this);
            }

            Console.WriteLine(string.Empty);
        }

        #endregion
    }
}