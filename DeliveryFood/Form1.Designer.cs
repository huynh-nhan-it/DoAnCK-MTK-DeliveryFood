
namespace DeliveryFood
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.enter_location = new System.Windows.Forms.Button();
            this.location_list = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(341, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Delivery";
            // 
            // enter_location
            // 
            this.enter_location.BackColor = System.Drawing.Color.Orange;
            this.enter_location.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_location.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enter_location.Location = new System.Drawing.Point(639, 480);
            this.enter_location.Name = "enter_location";
            this.enter_location.Size = new System.Drawing.Size(238, 54);
            this.enter_location.TabIndex = 2;
            this.enter_location.Text = "Enter";
            this.enter_location.UseVisualStyleBackColor = false;
            this.enter_location.Click += new System.EventHandler(this.enter_location_Click);
            // 
            // location_list
            // 
            this.location_list.BackColor = System.Drawing.Color.White;
            this.location_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_list.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.location_list.FormattingEnabled = true;
            this.location_list.ItemHeight = 37;
            this.location_list.Items.AddRange(new object[] {
            "Location",
            "District 7",
            "District 1",
            "District 2",
            "District 3",
            "District 4"});
            this.location_list.Location = new System.Drawing.Point(616, 224);
            this.location_list.Name = "location_list";
            this.location_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.location_list.Size = new System.Drawing.Size(261, 45);
            this.location_list.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(559, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.location_list);
            this.Controls.Add(this.enter_location);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter_location;
        private System.Windows.Forms.ComboBox location_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

