using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.RestaurantSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood.FoodDeliveryDriver
{
    public class RestaurantSearchDriver
    {
        public void RestaurantSearch(string location, Form1 form1, UserModel userModel)
        {
            List<CartModel> list = new List<CartModel>();
            InterpreterContext context = new InterpreterContext("Some API");
            RestaurantSearchClient client = new RestaurantSearchClient(context);
            var result = client.Intercept(location);
            if (!result.Any()) MessageBox.Show("Sorry, No Restaurants available in this location.");
           

            if (result.Any())
            {
                form1.Hide();
                Restaurants restaurants = new Restaurants(result, list, userModel);
                restaurants.Show();
            }
        }
    }
}
