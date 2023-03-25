using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.RestaurantWebService;
using DeliveryFood.Tracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood
{
    public partial class TrackingOrder : Form
    {
        private string orderID;
        private UserModel userModel;
        private double totalcost;
        private string location;

        public TrackingOrder(string orderID, UserModel userModel, double totalcost, string location)
        {
            this.orderID = orderID;
            this.userModel = userModel;
            this.totalcost = totalcost;
            this.location = location;
            InitializeComponent();
        }

        private async void TrackingOrder_Load(object sender, EventArgs e)
        {
            OrderID.Text = orderID;
            CustomerID.Text = userModel.UserId;
            name_custom.Text = userModel.UserName;
            Address.Text = userModel.Address;
            phone.Text = userModel.PhoneNumber;
            cost.Text = totalcost.ToString() + " VND";
            done.Visible = false;
            Customers customers = new Customers();
            Restaurant restaurant = new Restaurant(true, "");
            restaurant.Attach(customers);
            restaurant.image = true;
            restaurant.DeliveryStatus = "Đang chuẩn bị";
            status.Text = customers.lable;
            image_status1.Visible = customers.image;
            image_status2.Visible = !customers.image;
            image_status3.Visible = !customers.image;
            await Task.Delay(3000);
            restaurant.DeliveryStatus = "Đang giao";
            status.Text = customers.lable;
            image_status1.Visible = !customers.image;
            image_status2.Visible = customers.image;
            image_status3.Visible = !customers.image;
            await Task.Delay(3000);
           
            restaurant.DeliveryStatus = "Đã giao";
            status.Text = customers.lable;
            image_status1.Visible = !customers.image;
            image_status2.Visible = !customers.image;
            image_status3.Visible = customers.image;
            done.Visible = true;
        }

        private void done_Click(object sender, EventArgs e)
        {
            this.Hide();
            RestaurantService restaurantService = new RestaurantService("");
            List<CartModel> list_order = new List<CartModel>();
            var result = restaurantService.GetAllRestaurants().Where(item => item.Address.Contains(location));
            var restaurants = result.ToList();
            new Restaurants(restaurants, list_order, userModel).Show();
        }

        
    }
}
