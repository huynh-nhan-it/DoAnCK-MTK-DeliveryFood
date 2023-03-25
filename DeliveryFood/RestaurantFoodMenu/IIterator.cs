using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantFoodMenu
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
