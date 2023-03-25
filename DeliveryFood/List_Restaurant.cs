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
    public partial class List_Restaurant : UserControl
    {
        public List_Restaurant()
        {
            InitializeComponent();
        }

        private string name;
        private string rating;
        private string image;
        private string id;
        private Restaurants restaurants;
        private string location;
        public List<CartModel> list;
        private UserModel user;

        public List<CartModel> List
        {
            get { return list; }
            set { list = value; }
        }

        [Category("Custom Props")]
        public string Name_res
        {
            get { return name; }
            set { name = value; name_restaurant.Text = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value;}
        }

        public UserModel User
        {
            get { return user; }
            set { user = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Restaurants Get_Restaurants
        {
            get { return restaurants; }
            set { restaurants = value; }
        }

        [Category("Custom Props")]
        public string Rating
        {
            get { return rating; }
            set { rating = value; rating_restaurant.Text = value; }
        }


        [Category("Custom Props")]
        public string Image
        {
            get { return image; }
            set { image = value; image_restaurant.ImageLocation = value; image_restaurant.SizeMode = PictureBoxSizeMode.StretchImage;}
        }

        

        private void List_Restaurant_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void List_Restaurant_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            FoodMenuService foodMenuService = new FoodMenuService("", this.ID);
            var result = foodMenuService.getAllFoodMenu(this.ID);
            if (result.Any())
            {
                MealMenuIteratorDriver mealMenuIteratorDriver = new MealMenuIteratorDriver();
                mealMenuIteratorDriver.PrintMealMenu(this.ID, this.Get_Restaurants, this.Location, this.List, this.User);
            }
            else
            {
                MessageBox.Show("Hiện tại chưa có món nào ở nhà hàng");
            }
        }
    }
}
