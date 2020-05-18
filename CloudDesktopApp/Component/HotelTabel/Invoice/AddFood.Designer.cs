namespace CloudDesktopApp.Component.HotelTabel.Invoice
{
    partial class AddFood
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
            this.foodQty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addFoodButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.foodPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            this.createFoodLinkLable = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // foodQty
            // 
            this.foodQty.Depth = 0;
            this.foodQty.Hint = "Enter the number of qty";
            this.foodQty.Location = new System.Drawing.Point(11, 179);
            this.foodQty.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodQty.Name = "foodQty";
            this.foodQty.PasswordChar = '\0';
            this.foodQty.SelectedText = "";
            this.foodQty.SelectionLength = 0;
            this.foodQty.SelectionStart = 0;
            this.foodQty.Size = new System.Drawing.Size(282, 23);
            this.foodQty.TabIndex = 21;
            this.foodQty.UseSystemPasswordChar = false;
            // 
            // addFoodButton
            // 
            this.addFoodButton.AutoSize = true;
            this.addFoodButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFoodButton.Depth = 0;
            this.addFoodButton.Location = new System.Drawing.Point(81, 221);
            this.addFoodButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addFoodButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Primary = true;
            this.addFoodButton.Size = new System.Drawing.Size(135, 36);
            this.addFoodButton.TabIndex = 20;
            this.addFoodButton.Text = "Add Food Details";
            this.addFoodButton.UseVisualStyleBackColor = true;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // foodPrice
            // 
            this.foodPrice.Depth = 0;
            this.foodPrice.Enabled = false;
            this.foodPrice.Hint = "Enter the food price per qty";
            this.foodPrice.Location = new System.Drawing.Point(11, 134);
            this.foodPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.PasswordChar = '\0';
            this.foodPrice.SelectedText = "";
            this.foodPrice.SelectionLength = 0;
            this.foodPrice.SelectionStart = 0;
            this.foodPrice.Size = new System.Drawing.Size(282, 23);
            this.foodPrice.TabIndex = 22;
            this.foodPrice.UseSystemPasswordChar = false;
            // 
            // foodComboBox
            // 
            this.foodComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(12, 73);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(282, 27);
            this.foodComboBox.TabIndex = 24;
            this.foodComboBox.SelectedIndexChanged += new System.EventHandler(this.foodComboBox_SelectedIndexChanged);
            // 
            // createFoodLinkLable
            // 
            this.createFoodLinkLable.AutoSize = true;
            this.createFoodLinkLable.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createFoodLinkLable.LinkColor = System.Drawing.Color.Red;
            this.createFoodLinkLable.Location = new System.Drawing.Point(18, 109);
            this.createFoodLinkLable.Name = "createFoodLinkLable";
            this.createFoodLinkLable.Size = new System.Drawing.Size(270, 15);
            this.createFoodLinkLable.TabIndex = 25;
            this.createFoodLinkLable.TabStop = true;
            this.createFoodLinkLable.Text = "You not added any food, please add food click here.";
            this.createFoodLinkLable.Visible = false;
            this.createFoodLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createFoodLinkLable_LinkClicked);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 287);
            this.Controls.Add(this.createFoodLinkLable);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.foodPrice);
            this.Controls.Add(this.foodQty);
            this.Controls.Add(this.addFoodButton);
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Form";
            this.Load += new System.EventHandler(this.AddFood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField foodQty;
        private MaterialSkin.Controls.MaterialFlatButton addFoodButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodPrice;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.LinkLabel createFoodLinkLable;
    }
}