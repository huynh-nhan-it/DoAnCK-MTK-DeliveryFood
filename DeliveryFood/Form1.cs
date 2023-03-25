using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.FoodDeliveryDriver;
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
    public partial class Form1 : Form
    {
        private UserModel userModel;
        public Form1(UserModel userModel)
        {
            InitializeComponent();
            this.userModel = userModel;
        }
        
        private void enter_location_Click(object sender, EventArgs e)
        {
            if(location_list.Text == "Location")
            {
                MessageBox.Show("Please select the appropriate address");
            }
            else
            {
                RestaurantSearchDriver restaurantSearchDriver = new RestaurantSearchDriver();
                userModel.Address = location_list.Text;
                restaurantSearchDriver.RestaurantSearch(location_list.Text, this, userModel);
               
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            location_list.SelectedIndex = 0;
            location_list.SelectedText = "Location";
        }

      
    }
}
