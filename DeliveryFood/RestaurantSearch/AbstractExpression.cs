using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantSearch
{
    public abstract class AbstractExpression
    {
        public abstract List<RestaurantModel> Interpret(InterpreterContext context);
    }
}
