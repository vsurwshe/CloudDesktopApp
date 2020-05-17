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
            this.foodName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.foodPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // foodQty
            // 
            this.foodQty.Depth = 0;
            this.foodQty.Hint = "Enter the number of qty";
            this.foodQty.Location = new System.Drawing.Point(12, 164);
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
            this.addFoodButton.Location = new System.Drawing.Point(85, 196);
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
            // foodName
            // 
            this.foodName.Depth = 0;
            this.foodName.Hint = "Enter the food name";
            this.foodName.Location = new System.Drawing.Point(12, 81);
            this.foodName.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodName.Name = "foodName";
            this.foodName.PasswordChar = '\0';
            this.foodName.SelectedText = "";
            this.foodName.SelectionLength = 0;
            this.foodName.SelectionStart = 0;
            this.foodName.Size = new System.Drawing.Size(282, 23);
            this.foodName.TabIndex = 23;
            this.foodName.UseSystemPasswordChar = false;
            // 
            // foodPrice
            // 
            this.foodPrice.Depth = 0;
            this.foodPrice.Hint = "Enter the food price per qty";
            this.foodPrice.Location = new System.Drawing.Point(12, 119);
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
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 243);
            this.Controls.Add(this.foodName);
            this.Controls.Add(this.foodPrice);
            this.Controls.Add(this.foodQty);
            this.Controls.Add(this.addFoodButton);
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField foodQty;
        private MaterialSkin.Controls.MaterialFlatButton addFoodButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodName;
        private MaterialSkin.Controls.MaterialSingleLineTextField foodPrice;
    }
}