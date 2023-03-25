
namespace DeliveryFood
{
    partial class CartItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.image_food = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_food = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.rating_restaurant = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_food = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.PictureBox();
            this.plus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plus)).BeginInit();
            this.SuspendLayout();
            // 
            // image_food
            // 
            this.image_food.Location = new System.Drawing.Point(3, 0);
            this.image_food.Name = "image_food";
            this.image_food.Size = new System.Drawing.Size(252, 187);
            this.image_food.TabIndex = 2;
            this.image_food.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(3, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 5);
            this.panel1.TabIndex = 6;
            // 
            // name_food
            // 
            this.name_food.AutoSize = true;
            this.name_food.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_food.Location = new System.Drawing.Point(291, 17);
            this.name_food.Name = "name_food";
            this.name_food.Size = new System.Drawing.Size(70, 23);
            this.name_food.TabIndex = 7;
            this.name_food.Text = "Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(291, 88);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(58, 23);
            this.price.TabIndex = 10;
            this.price.Text = "Price";
            // 
            // rating_restaurant
            // 
            this.rating_restaurant.AutoSize = true;
            this.rating_restaurant.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_restaurant.Location = new System.Drawing.Point(290, 152);
            this.rating_restaurant.Name = "rating_restaurant";
            this.rating_restaurant.Size = new System.Drawing.Size(31, 34);
            this.rating_restaurant.TabIndex = 11;
            this.rating_restaurant.Text = "5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quantity";
            // 
            // quantity_food
            // 
            this.quantity_food.AutoSize = true;
            this.quantity_food.Font = new System.Drawing.Font("Century Gothic", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_food.Location = new System.Drawing.Point(755, 108);
            this.quantity_food.Name = "quantity_food";
            this.quantity_food.Size = new System.Drawing.Size(31, 34);
            this.quantity_food.TabIndex = 14;
            this.quantity_food.Text = "0";
            // 
            // sub
            // 
            this.sub.Image = ((System.Drawing.Image)(resources.GetObject("sub.Image")));
            this.sub.Location = new System.Drawing.Point(718, 112);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(33, 30);
            this.sub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sub.TabIndex = 15;
            this.sub.TabStop = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // plus
            // 
            this.plus.Image = ((System.Drawing.Image)(resources.GetObject("plus.Image")));
            this.plus.Location = new System.Drawing.Point(789, 112);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(33, 30);
            this.plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plus.TabIndex = 16;
            this.plus.TabStop = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.plus);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.quantity_food);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rating_restaurant);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name_food);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.image_food);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(908, 205);
            ((System.ComponentModel.ISupportInitialize)(this.image_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_food;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name_food;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label rating_restaurant;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantity_food;
        private System.Windows.Forms.PictureBox sub;
        private System.Windows.Forms.PictureBox plus;
    }
}
