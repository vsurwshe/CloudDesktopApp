namespace CloudDesktopApp.Component.HotelTabel.Invoice
{
    partial class BookTable
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
            this.bookTableButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.customerSize = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.customerName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // bookTableButton
            // 
            this.bookTableButton.AutoSize = true;
            this.bookTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookTableButton.Depth = 0;
            this.bookTableButton.Location = new System.Drawing.Point(93, 146);
            this.bookTableButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bookTableButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookTableButton.Name = "bookTableButton";
            this.bookTableButton.Primary = true;
            this.bookTableButton.Size = new System.Drawing.Size(122, 36);
            this.bookTableButton.TabIndex = 17;
            this.bookTableButton.Text = "Book The Table";
            this.bookTableButton.UseVisualStyleBackColor = true;
            this.bookTableButton.Click += new System.EventHandler(this.bookTableButton_Click);
            // 
            // customerSize
            // 
            this.customerSize.Depth = 0;
            this.customerSize.Hint = "Enter the number of customer";
            this.customerSize.Location = new System.Drawing.Point(24, 114);
            this.customerSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerSize.Name = "customerSize";
            this.customerSize.PasswordChar = '\0';
            this.customerSize.SelectedText = "";
            this.customerSize.SelectionLength = 0;
            this.customerSize.SelectionStart = 0;
            this.customerSize.Size = new System.Drawing.Size(282, 23);
            this.customerSize.TabIndex = 16;
            this.customerSize.UseSystemPasswordChar = false;
            // 
            // customerName
            // 
            this.customerName.Depth = 0;
            this.customerName.Hint = "Enter the customer name";
            this.customerName.Location = new System.Drawing.Point(24, 76);
            this.customerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerName.Name = "customerName";
            this.customerName.PasswordChar = '\0';
            this.customerName.SelectedText = "";
            this.customerName.SelectionLength = 0;
            this.customerName.SelectionStart = 0;
            this.customerName.Size = new System.Drawing.Size(282, 23);
            this.customerName.TabIndex = 18;
            this.customerName.UseSystemPasswordChar = false;
            // 
            // BookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 198);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.bookTableButton);
            this.Controls.Add(this.customerSize);
            this.Name = "BookTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton bookTableButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerSize;
        private MaterialSkin.Controls.MaterialSingleLineTextField customerName;
    }
}