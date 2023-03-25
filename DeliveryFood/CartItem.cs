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
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }


        private string _name;
        private string _price;
        private string _rating;
        private string _image;
        private string _quantity;
        private FoodMenuModel itemFood;
        public List<CartModel> list;


        [Category("Custom Props")]
        public string Name_food
        {
            get { return _name; }
            set { _name = value; name_food.Text = value; }
        }


        [Category("Custom Props")]
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; rating_restaurant.Text = value; }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; price.Text = value; }
        }

        [Category("Custom Props")]
        public string Image
        {
            get { return _image; }
            set { _image = value; image_food.ImageLocation = value; image_food.SizeMode = PictureBoxSizeMode.StretchImage; }
        }

        [Category("Custom Props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantity_food.Text = value; }
        }

        public List<CartModel> List
        {
            get { return list; }
            set { list = value; }
        }

        public FoodMenuModel ItemFood
        {
            get { return itemFood; }
            set { itemFood = value; }
        }

        private bool check()
        {
            var result = this.List.Where(e => e.Food.FoodId.Contains(this.ItemFood.FoodId)).ToList();
            if (result.Any())
            {
                return false;
            }

            return true;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            int _quatity = Int32.Parse(quantity_food.Text) - 1;
            if (_quatity == 0 && !check())
            {
                quantity_food.Text = "0";
                var result = this.List.Where(item => item.Food.FoodId.Contains(this.ItemFood.FoodId)).ToList();
                this.List.Remove(result[0]);
            }
            else if (_quatity > 0 && !check())
            {
                var result = this.List.Where(item => item.Food.FoodId.Contains(this.ItemFood.FoodId)).ToList();
                result[0].Quantity = _quatity;
                quantity_food.Text = _quatity.ToString();
            }
            else
            {
                quantity_food.Text = "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int _quatity = Int32.Parse(quantity_food.Text) + 1;
            if (check())
            {
                this.List.Add(new CartModel(this.ItemFood, _quatity));
            }
            else
            {
                var result = this.List.Where(item => item.Food.FoodId.Contains(this.ItemFood.FoodId)).ToList();
                result[0].Quantity = result[0].Quantity + 1;
            }

            quantity_food.Text = _quatity.ToString();
        }
    }
}
