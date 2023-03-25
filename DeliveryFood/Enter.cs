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
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (name.Text == "" | phonenumber.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ");
            }
            else
            {
                UserModel userModel = new UserModel();
                userModel.PhoneNumber = phonenumber.Text;
                userModel.UserName = name.Text;
                userModel.UserId = "001";
                this.Hide();
                new Form1(userModel).Show();
            }
        }
    }
}
