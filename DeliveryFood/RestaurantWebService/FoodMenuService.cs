using DeliveryFood.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFood.RestaurantWebService
{
    public class FoodMenuService
    {
        List<FoodMenuModel> foodMenu = new List<FoodMenuModel>();
        public FoodMenuService(string endPoint, string restaurantId)
        {
            //Initialize web service with the endpoint string.
            //Data for food Menu items will fetch based on the Restaurant Id.
        }

        public List<FoodMenuModel> getAllFoodMenu(string restaurantId)
        {
            addData();
            var result = foodMenu.Where(e => e.RestaurantId.Contains(restaurantId));
            var food_Menu = result.ToList();
            return food_Menu;
        }

        private void addData()
        {
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "001", Cuisine = "Indian", FoodName = "Chicken Biryani", Rating = 5, Rate = 250 , Image = "../images/food1.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "002", Cuisine = "Indian", FoodName = "Chicken Korma", Rating = 4, Rate = 300, Image = "../images/food2.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "003", Cuisine = "Indian", FoodName = "Shahi Paneer", Rating = 5, Rate = 250 , Image = "../images/food3.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "004", Cuisine = "Indian", FoodName = "Tandoori Roti", Rating = 3, Rate = 250 , Image = "../images/food4.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "001", FoodId = "005", Cuisine = "Indian", FoodName = "Choley Bhaturey", Rating = 5, Rate = 100 , Image = "../images/food5.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "006", Cuisine = "Indian", FoodName = "Shrimp soup", Rating = 5, Rate = 250, Image = "../images/food6.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "007", Cuisine = "Indian", FoodName = "Seafood soup", Rating = 4, Rate = 300, Image = "../images/food7.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "008", Cuisine = "Indian", FoodName = "Peanuts dived", Rating = 5, Rate = 250, Image = "../images/food8.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "009", Cuisine = "Indian", FoodName = "Kimchi", Rating = 3, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "002", FoodId = "010", Cuisine = "Indian", FoodName = "Fresh Shellfish", Rating = 5, Rate = 100, Image = "../images/food10.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "011", Cuisine = "Indian", FoodName = "Eel soup", Rating = 5, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "012", Cuisine = "Indian", FoodName = "Crab soup", Rating = 4, Rate = 300, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "013", Cuisine = "Indian", FoodName = "Beef soup", Rating = 5, Rate = 250, Image = "../images/food13.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "014", Cuisine = "Indian", FoodName = "Rice noodles", Rating = 3, Rate = 250, Image = "../images/food14.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "003", FoodId = "015", Cuisine = "Indian", FoodName = "Kebab rice", Rating = 5, Rate = 100, Image = "../images/food15.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "016", Cuisine = "Indian", FoodName = "Crab rice", Rating = 5, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "017", Cuisine = "Indian", FoodName = "Beef rice", Rating = 4, Rate = 300, Image = "../images/food10.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "018", Cuisine = "Indian", FoodName = "Rice gruel", Rating = 5, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "019", Cuisine = "Indian", FoodName = "Meretrix Rice", Rating = 3, Rate = 250, Image = "../images/food15.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "004", FoodId = "020", Cuisine = "Indian", FoodName = "Fried rice", Rating = 5, Rate = 100, Image = "../images/food11.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "021", Cuisine = "Indian", FoodName = "Eel Rice", Rating = 5, Rate = 250, Image = "../images/food6.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "022", Cuisine = "Indian", FoodName = "Curry chicken", Rating = 4, Rate = 300, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "023", Cuisine = "Indian", FoodName = "Chicken Rice", Rating = 5, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "024", Cuisine = "Indian", FoodName = "Steamed sticky", Rating = 3, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "005", FoodId = "025", Cuisine = "Indian", FoodName = "Steamed rice", Rating = 5, Rate = 100, Image = "../images/food10.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "006", FoodId = "026", Cuisine = "Indian", FoodName = "Grilled Rabbit", Rating = 5, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "006", FoodId = "027", Cuisine = "Indian", FoodName = "Stewed Rabbit", Rating = 4, Rate = 300, Image = "../images/food10.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "006", FoodId = "028", Cuisine = "Indian", FoodName = "Rabbit cooked", Rating = 5, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "006", FoodId = "029", Cuisine = "Indian", FoodName = "Roti fried", Rating = 3, Rate = 250, Image = "../images/food13.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "006", FoodId = "030", Cuisine = "Indian", FoodName = "Fried boned", Rating = 5, Rate = 100, Image = "../images/food11.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "007", FoodId = "031", Cuisine = "Indian", FoodName = "Fried Rabbit", Rating = 5, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "007", FoodId = "032", Cuisine = "Indian", FoodName = "Stewed Rabbit", Rating = 4, Rate = 300, Image = "../images/food8.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "007", FoodId = "033", Cuisine = "Indian", FoodName = "Lobster", Rating = 5, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "007", FoodId = "034", Cuisine = "Indian", FoodName = "Steamed Sugpo", Rating = 3, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "007", FoodId = "035", Cuisine = "Indian", FoodName = "Sugpo prawn", Rating = 5, Rate = 100, Image = "../images/food10.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "008", FoodId = "036", Cuisine = "Indian", FoodName = "Roasted Sugpo", Rating = 5, Rate = 250, Image = "../images/food7.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "008", FoodId = "037", Cuisine = "Indian", FoodName = "Steamed Lobster", Rating = 4, Rate = 300, Image = "../images/food6.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "008", FoodId = "038", Cuisine = "Indian", FoodName = "Grilled Lobster", Rating = 5, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "008", FoodId = "039", Cuisine = "Indian", FoodName = "Toasted Crayfish", Rating = 3, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "008", FoodId = "040", Cuisine = "Indian", FoodName = "Fried Crayfish", Rating = 5, Rate = 100, Image = "../images/food13.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "009", FoodId = "041", Cuisine = "Indian", FoodName = "Boil Cockle", Rating = 5, Rate = 250, Image = "../images/food14.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "009", FoodId = "042", Cuisine = "Indian", FoodName = "Steamed Cockle", Rating = 4, Rate = 300, Image = "../images/food15.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "009", FoodId = "043", Cuisine = "Indian", FoodName = "Cuttle fish", Rating = 5, Rate = 250, Image = "../images/food13.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "009", FoodId = "044", Cuisine = "Indian", FoodName = "Fried Squid", Rating = 3, Rate = 250, Image = "../images/food10.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "009", FoodId = "045", Cuisine = "Indian", FoodName = "Steamed Squid", Rating = 5, Rate = 100, Image = "../images/food8.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "010", FoodId = "046", Cuisine = "Indian", FoodName = "Soused Squid", Rating = 5, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "010", FoodId = "047", Cuisine = "Indian", FoodName = "Tortoise", Rating = 4, Rate = 300, Image = "../images/food7.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "010", FoodId = "048", Cuisine = "Indian", FoodName = "Roasted Turtle", Rating = 5, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "010", FoodId = "049", Cuisine = "Indian", FoodName = "Grilled Turtle", Rating = 3, Rate = 250, Image = "../images/food13.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "010", FoodId = "050", Cuisine = "Indian", FoodName = "Makhani", Rating = 5, Rate = 100, Image = "../images/food10.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "011", FoodId = "051", Cuisine = "Indian", FoodName = "Samosas", Rating = 5, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "011", FoodId = "052", Cuisine = "Indian", FoodName = "Stuffed pancake", Rating = 4, Rate = 300, Image = "../images/food14.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "011", FoodId = "053", Cuisine = "Indian", FoodName = "Girdle-cake", Rating = 5, Rate = 250, Image = "../images/food15.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "011", FoodId = "054", Cuisine = "Indian", FoodName = "Shrimp in batter", Rating = 3, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "011", FoodId = "055", Cuisine = "Indian", FoodName = "Young rice cake", Rating = 5, Rate = 100, Image = "../images/food2.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "012", FoodId = "056", Cuisine = "Indian", FoodName = "Soya cake", Rating = 5, Rate = 250, Image = "../images/food2.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "012", FoodId = "057", Cuisine = "Indian", FoodName = "Pancako", Rating = 4, Rate = 300, Image = "../images/food5.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "012", FoodId = "058", Cuisine = "Indian", FoodName = "Abalone", Rating = 5, Rate = 250, Image = "../images/food6.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "012", FoodId = "059", Cuisine = "Indian", FoodName = "Snail rice", Rating = 3, Rate = 250, Image = "../images/food11.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "012", FoodId = "060", Cuisine = "Indian", FoodName = "Kebab rice", Rating = 5, Rate = 100, Image = "../images/food12.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "013", FoodId = "061", Cuisine = "Indian", FoodName = "Fish cooked", Rating = 5, Rate = 250, Image = "../images/food6.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "013", FoodId = "062", Cuisine = "Indian", FoodName = "Soya cheese", Rating = 4, Rate = 300, Image = "../images/food4.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "013", FoodId = "063", Cuisine = "Indian", FoodName = "Raw fish", Rating = 5, Rate = 250, Image = "../images/food3.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "013", FoodId = "064", Cuisine = "Indian", FoodName = "Chinese sausage", Rating = 3, Rate = 250, Image = "../images/food13.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "013", FoodId = "065", Cuisine = "Indian", FoodName = "Soya noodles", Rating = 5, Rate = 100, Image = "../images/food12.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "014", FoodId = "066", Cuisine = "Indian", FoodName = "Spring roll", Rating = 5, Rate = 250, Image = "../images/food5.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "014", FoodId = "067", Cuisine = "Indian", FoodName = "Coconut milk", Rating = 4, Rate = 300, Image = "../images/food7.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "014", FoodId = "068", Cuisine = "Indian", FoodName = "Sticky rice", Rating = 5, Rate = 250, Image = "../images/food8.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "014", FoodId = "069", Cuisine = "Indian", FoodName = "Baked Honey", Rating = 3, Rate = 250, Image = "../images/food12.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "014", FoodId = "070", Cuisine = "Indian", FoodName = "Cassava", Rating = 5, Rate = 100, Image = "../images/food13.jpg" });

            foodMenu.Add(new FoodMenuModel { RestaurantId = "015", FoodId = "071", Cuisine = "Indian", FoodName = " Stuffer pancak", Rating = 5, Rate = 250, Image = "../images/food1.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "015", FoodId = "072", Cuisine = "Indian", FoodName = "Bamboo ѕprout", Rating = 4, Rate = 300, Image = "../images/food3.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "015", FoodId = "073", Cuisine = "Indian", FoodName = "Salted ᴠegetableѕ", Rating = 5, Rate = 250, Image = "../images/food5.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "015", FoodId = "074", Cuisine = "Indian", FoodName = "Snail rice noodleѕ", Rating = 3, Rate = 250, Image = "../images/food9.jpg" });
            foodMenu.Add(new FoodMenuModel { RestaurantId = "015", FoodId = "075", Cuisine = "Indian", FoodName = "Freѕh-ᴡater crab", Rating = 5, Rate = 100, Image = "../images/food15.jpg" });



        }
    }
}
