using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantWebService
{
    public class RestaurantService
    {
        public RestaurantService(string endPoint)
        {
            //Initialize web service with the endpoint string.
        }

        /// <summary>
        /// This method should expose Webservice to fetch all Restaurants.
        /// </summary>
        public List<RestaurantModel> GetAllRestaurants()
        {
            List<RestaurantModel> restaurants = new List<RestaurantModel>();
            restaurants.Add(new RestaurantModel { RestaurantId = "001", Name = "Barbequnation", Address = "District 7", Rating = 5, image = "../images/Restaurant1.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "002", Name = "Paradize", Address = "District 7", Rating = 3, image = "../images/Restaurant2.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "003", Name = "Thirteenth floor", Address = "District 7", Rating = 4, image = "../images/Restaurant3.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "004", Name = "Mango Tree", Address = "District 1", Rating = 2 , image = "../images/Restaurant4.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "005", Name = "Brewsky", Address = "District 1", Rating = 4, image = "../images/Restaurant5.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "006", Name = "Osteria Francescana", Address = "District 1", Rating = 3, image = "../images/Restaurant6.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "007", Name = "Can Roca", Address = "District 2", Rating = 4, image = "../images/Restaurant7.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "008", Name = "Mirazur", Address = "District 2", Rating = 5, image = "../images/Restaurant8.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "009", Name = "Eleven Madison", Address = "District 2", Rating = 3, image = "../images/Restaurant9.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "010", Name = "Gaggan", Address = "District 3", Rating = 5, image = "../images/Restaurant10.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "011", Name = "Central", Address = "District 3", Rating = 3, image = "../images/Restaurant11.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "012", Name = "Maido", Address = "District 3", Rating = 4, image = "../images/Restaurant12.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "013", Name = "L’Arpege", Address = "District 4", Rating = 3, image = "../images/Restaurant13.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "014", Name = "Mugaritz", Address = "District 4", Rating = 4, image = "../images/Restaurant14.jpg" });
            restaurants.Add(new RestaurantModel { RestaurantId = "015", Name = "Asador Etxebarri", Address = "District 4", Rating = 5, image = "../images/Restaurant15.jpg" });
            return restaurants;
        }
    }
}
