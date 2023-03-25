using DeliveryFood.FoodDeliveryAppModel;
using DeliveryFood.RestaurantWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood.OrderAndCancellation
{
    public class Food
    {
        public void OrderFood(string orderID, UserModel user, double totalCost, string location, Payment payment)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán đơn hàng chứ", "Đơn hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                payment.Hide();
                new TrackingOrder(orderID, user, totalCost, location).Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public void CancelFood(string location, Payment payment, UserModel user)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn hủy đơn hàng chứ", "Đơn hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                payment.Hide();
                RestaurantService restaurantService = new RestaurantService("");
                List<CartModel> list_order = new List<CartModel>();
                var result = restaurantService.GetAllRestaurants().Where(item => item.Address.Contains(location));
                var restaurants = result.ToList();
                new Restaurants(restaurants, list_order, user).Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
