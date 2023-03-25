using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.FoodDeliveryDriver;
using DeliveryFood.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood
{
    public partial class Cart : Form
    {

        private string location;
        private List<CartModel> list_order;
        private UserModel userModel;
        public Cart(string location, List<CartModel> list_order, UserModel userModel)
        {
            InitializeComponent();
            this.location = location;
            this.list_order = list_order;
            this.userModel = userModel;
        }

        
        private void populateFoodMenu()
        {
            CartItem[] _listorder = new CartItem[list_order.Count];

            for (int i = 0; i < _listorder.Length; i++)
            {
                _listorder[i] = new CartItem();
                _listorder[i].Name_food = list_order[i].Food.FoodName;
                _listorder[i].Rating = list_order[i].Food.Rating.ToString();
                _listorder[i].Image = list_order[i].Food.Image;
                _listorder[i].Price = list_order[i].Food.Rate.ToString() + " VND";
                _listorder[i].Quantity = list_order[i].Quantity.ToString();
                _listorder[i].ItemFood = list_order[i].Food;
                _listorder[i].List = list_order;
                flowLayoutPanel1.Controls.Add(_listorder[i]);
            }
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            populateFoodMenu();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestaurantService restaurantService = new RestaurantService("");
            var result = restaurantService.GetAllRestaurants().Where(item => item.Address.Contains(location));
            var restaurants = result.ToList();
            new Restaurants(restaurants, list_order, userModel).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealBuilderDriver mealBuilderDriver = new MealBuilderDriver();
            Random random = new Random();
            int rating = random.Next(1, 5);
            mealBuilderDriver.BuildMealForUser(list_order, rating, this, location, userModel);
        }
    }
}
