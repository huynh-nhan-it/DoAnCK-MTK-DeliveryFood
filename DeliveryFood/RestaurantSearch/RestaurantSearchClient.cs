using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantSearch
{
    public class RestaurantSearchClient
    {
        private readonly InterpreterContext context;

        public RestaurantSearchClient(InterpreterContext context)
        {
            this.context = context;
        }

        public List<RestaurantModel> Intercept(string expression)
        {
            AbstractExpression queryExpression = null;
            queryExpression = new RestaurantLocationExpression(expression);
            if (queryExpression != null)
                return queryExpression.Interpret(this.context);

            return null;
        }
    }
}
