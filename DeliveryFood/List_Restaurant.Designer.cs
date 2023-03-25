
namespace DeliveryFood
{
    partial class List_Restaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Restaurant));
            this.image_restaurant = new System.Windows.Forms.PictureBox();
            this.name_restaurant = new System.Windows.Forms.Label();
            this.rating_restaurant = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.image_restaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // image_restaurant
            // 
            this.image_restaurant.Location = new System.Drawing.Point(3, 3);
            this.image_restaurant.Name = "image_restaurant";
            this.image_restaurant.Size = new System.Drawing.Size(238, 122);
            this.image_restaurant.TabIndex = 0;
            this.image_restaurant.TabStop = false;
            // 
            // name_restaurant
            // 
            this.name_restaurant.AutoSize = true;
            this.name_restaurant.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_restaurant.Location = new System.Drawing.Point(282, 17);
            this.name_restaurant.Name = "name_restaurant";
            this.name_restaurant.Size = new System.Drawing.Size(84, 28);
            this.name_restaurant.TabIndex = 1;
            this.name_restaurant.Text = "Name";
            // 
            // rating_restaurant
            // 
            this.rating_restaurant.AutoSize = true;
            this.rating_restaurant.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating_restaurant.Location = new System.Drawing.Point(281, 74);
            this.rating_restaurant.Name = "rating_restaurant";
            this.rating_restaurant.Size = new System.Drawing.Size(31, 34);
            this.rating_restaurant.TabIndex = 2;
            this.rating_restaurant.Text = "5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(313, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(3, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 5);
            this.panel1.TabIndex = 4;
            // 
            // List_Restaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rating_restaurant);
            this.Controls.Add(this.name_restaurant);
            this.Controls.Add(this.image_restaurant);
            this.Name = "List_Restaurant";
            this.Size = new System.Drawing.Size(775, 133);
            this.Click += new System.EventHandler(this.List_Restaurant_Click);
            this.MouseLeave += new System.EventHandler(this.List_Restaurant_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.image_restaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_restaurant;
        private System.Windows.Forms.Label name_restaurant;
        private System.Windows.Forms.Label rating_restaurant;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
