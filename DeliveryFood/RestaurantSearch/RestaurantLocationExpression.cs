using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantSearch
{
    public class RestaurantLocationExpression : AbstractExpression
    {
        private readonly String searchString;

        public RestaurantLocationExpression(String searchString)
        {
            this.searchString = searchString;
        }
        public override List<RestaurantModel> Interpret(InterpreterContext context)
        {
            List<RestaurantModel> restaurants = context.GetAllRestaurants();

            var result = restaurants.Where(e => e.Address.Contains(this.searchString));
            var restaurantResult = result.ToList();

            return restaurantResult;
        }
    }
}
