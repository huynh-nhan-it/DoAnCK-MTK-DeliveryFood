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
    public partial class Payment : Form
    {
        private string location;
        private List<CartModel> list_order;
        private string totalCost;
        private string totalTax;
        private UserModel userModel;
        public Payment(string location, List<CartModel> list_order, string totalCost, string totalTax, UserModel userModel)
        {
            InitializeComponent();
            this.location = location;
            this.list_order = list_order;
            this.totalCost = totalCost;
            this.totalTax = totalTax;
            this.userModel = userModel;
        }

        private void populateFoodMenu()
        {
            Order[] _listorder = new Order[list_order.Count];

            for (int i = 0; i < _listorder.Length; i++)
            {
                _listorder[i] = new Order();
                _listorder[i].Name_food = list_order[i].Food.FoodName;
                _listorder[i].Rating = list_order[i].Food.Rating.ToString();
                _listorder[i].Image = list_order[i].Food.Image;
                _listorder[i].Price = list_order[i].Food.Rate.ToString() + " VND";
                _listorder[i].Quantity = list_order[i].Quantity.ToString();
                
                flowLayoutPanel1.Controls.Add(_listorder[i]);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cost.Text = totalCost + " VND";
            tax.Text = totalTax + " VND";
            populateFoodMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealOrderDriver mealOrder = new MealOrderDriver();
            mealOrder.MealOrderByUser(false, location, userModel, this, double.Parse(totalCost));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealOrderDriver mealOrder = new MealOrderDriver();
            mealOrder.MealOrderByUser(true, location, userModel, this, double.Parse(totalCost));
        }
    }
}
