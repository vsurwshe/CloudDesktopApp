namespace CloudDesktopApp.Component.HotelTabel
{
    partial class HotelTabelForm
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
            this.hotelTabelName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.hotelTableLocations = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.saveHotelTableButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.hotelTabelSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // hotelTabelName
            // 
            this.hotelTabelName.Depth = 0;
            this.hotelTabelName.Hint = "Enter the tabel name";
            this.hotelTabelName.Location = new System.Drawing.Point(12, 69);
            this.hotelTabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.hotelTabelName.Name = "hotelTabelName";
            this.hotelTabelName.PasswordChar = '\0';
            this.hotelTabelName.SelectedText = "";
            this.hotelTabelName.SelectionLength = 0;
            this.hotelTabelName.SelectionStart = 0;
            this.hotelTabelName.Size = new System.Drawing.Size(282, 23);
            this.hotelTabelName.TabIndex = 0;
            this.hotelTabelName.UseSystemPasswordChar = false;
            // 
            // hotelTableLocations
            // 
            this.hotelTableLocations.Depth = 0;
            this.hotelTableLocations.Hint = "Enter the hotel table locations";
            this.hotelTableLocations.Location = new System.Drawing.Point(12, 98);
            this.hotelTableLocations.MouseState = MaterialSkin.MouseState.HOVER;
            this.hotelTableLocations.Name = "hotelTableLocations";
            this.hotelTableLocations.PasswordChar = '\0';
            this.hotelTableLocations.SelectedText = "";
            this.hotelTableLocations.SelectionLength = 0;
            this.hotelTableLocations.SelectionStart = 0;
            this.hotelTableLocations.Size = new System.Drawing.Size(282, 23);
            this.hotelTableLocations.TabIndex = 1;
            this.hotelTableLocations.UseSystemPasswordChar = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 204);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 12);
            this.progressBar.TabIndex = 23;
            this.progressBar.Visible = false;
            // 
            // saveHotelTableButton
            // 
            this.saveHotelTableButton.AutoSize = true;
            this.saveHotelTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveHotelTableButton.Depth = 0;
            this.saveHotelTableButton.Location = new System.Drawing.Point(79, 159);
            this.saveHotelTableButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveHotelTableButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveHotelTableButton.Name = "saveHotelTableButton";
            this.saveHotelTableButton.Primary = true;
            this.saveHotelTableButton.Size = new System.Drawing.Size(149, 36);
            this.saveHotelTableButton.TabIndex = 3;
            this.saveHotelTableButton.Text = "Save Hotel Details";
            this.saveHotelTableButton.UseVisualStyleBackColor = true;
            this.saveHotelTableButton.Click += new System.EventHandler(this.saveHotelTableButton_Click);
            // 
            // hotelTabelSize
            // 
            this.hotelTabelSize.Depth = 0;
            this.hotelTabelSize.Hint = "Enter the tabel customer size";
            this.hotelTabelSize.Location = new System.Drawing.Point(12, 127);
            this.hotelTabelSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.hotelTabelSize.Name = "hotelTabelSize";
            this.hotelTabelSize.PasswordChar = '\0';
            this.hotelTabelSize.SelectedText = "";
            this.hotelTabelSize.SelectionLength = 0;
            this.hotelTabelSize.SelectionStart = 0;
            this.hotelTabelSize.Size = new System.Drawing.Size(282, 23);
            this.hotelTabelSize.TabIndex = 2;
            this.hotelTabelSize.UseSystemPasswordChar = false;
            // 
            // HotelTabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 228);
            this.Controls.Add(this.hotelTabelName);
            this.Controls.Add(this.hotelTableLocations);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.saveHotelTableButton);
            this.Controls.Add(this.hotelTabelSize);
            this.Name = "HotelTabelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Tabel Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField hotelTabelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField hotelTableLocations;
        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton saveHotelTableButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField hotelTabelSize;
    }
}