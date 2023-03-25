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
    public partial class Menu : Form
    {
        private List<FoodMenuModel> list_food;
        private string location;
        private List<CartModel> list_order;
        private UserModel userModel;
        public Menu(List<FoodMenuModel> list_food, string location, List<CartModel> list_order, UserModel userModel)
        {
            InitializeComponent();
            this.list_food = list_food ;
            this.location = location;
            this.list_order = list_order;
            this.userModel = userModel;
        }

        private void populateFoodMenu()
        {
            MenuFood[] _listfood = new MenuFood[list_food.Count];

            for (int i = 0; i < _listfood.Length; i++)
            {
                _listfood[i] = new MenuFood();
                _listfood[i].Name_food = list_food[i].FoodName;
                _listfood[i].Rating = list_food[i].Rating.ToString();
                _listfood[i].Image = list_food[i].Image;
                _listfood[i].Price = list_food[i].Rate.ToString() + " VND";
                _listfood[i].ItemFood = list_food[i];
                _listfood[i].List = list_order;
                flowLayoutPanel1.Controls.Add(_listfood[i]);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
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

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (list_order.Count == 0)
            {
                MessageBox.Show("Hiện tại chưa có đơn hàng nào");
            }
            else
            {
                this.Hide();
                new Cart(location, list_order, userModel).Show();
            }
        }
    }
}
