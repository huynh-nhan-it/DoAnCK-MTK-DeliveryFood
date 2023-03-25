using DeliveryFood.FoodDeliveryAppModel;
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
    public partial class Restaurants : Form
    {
        private List<RestaurantModel> list_restaurant;
        private List<CartModel> list_order;
        private UserModel userModel;
     
        public Restaurants(List<RestaurantModel> list, List<CartModel> list_order, UserModel userModel)
        {
            InitializeComponent();
            list_restaurant = list;
            this.list_order = list_order;
            this.userModel = userModel;
           
        }

        private void Restaurants_Load(object sender, EventArgs e)
        {
            populateRestaurant();
            
        }

        private void populateRestaurant()
        {
            List_Restaurant[] list_Restaurant = new List_Restaurant[list_restaurant.Count];
            
            for(int i = 0; i < list_Restaurant.Length; i++)
            {
                list_Restaurant[i] = new List_Restaurant();
                list_Restaurant[i].Name_res = list_restaurant[i].Name;
                list_Restaurant[i].Rating = list_restaurant[i].Rating.ToString();
                list_Restaurant[i].Image = list_restaurant[i].image;
                list_Restaurant[i].ID = list_restaurant[i].RestaurantId;
                list_Restaurant[i].Get_Restaurants = this;
                list_Restaurant[i].Location = list_restaurant[i].Address;
                list_Restaurant[i].List = list_order;
                list_Restaurant[i].User = userModel;
                flowLayoutPanel1.Controls.Add(list_Restaurant[i]);
            }
        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            
                DialogResult dialogResult = MessageBox.Show("Các đơn hàng của bạn sẽ bị xóa", "Địa chỉ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    new Form1(userModel).Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
           
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
                new Cart(list_restaurant[0].Address, list_order, userModel).Show();
            }
        }
    }
}
