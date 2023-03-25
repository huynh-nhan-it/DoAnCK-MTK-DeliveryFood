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
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
        }

        private string _name;
        private string _price;
        private string _rating;
        private string _image;
        private string _quantity;
      
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
    }
}
