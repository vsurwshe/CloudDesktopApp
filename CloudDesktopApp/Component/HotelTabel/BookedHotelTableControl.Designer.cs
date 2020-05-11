namespace CloudDesktopApp.Component.HotelTabel
{
    partial class BookedHotelTableControl
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
            this.tableNumber = new MaterialSkin.Controls.MaterialLabel();
            this.addFoodInvoiceItemButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.viewInvoiceButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.unbookedTableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.Depth = 0;
            this.tableNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableNumber.Location = new System.Drawing.Point(40, 60);
            this.tableNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(17, 19);
            this.tableNumber.TabIndex = 32;
            this.tableNumber.Text = "0";
            // 
            // addFoodInvoiceItemButton
            // 
            this.addFoodInvoiceItemButton.BackColor = System.Drawing.Color.Transparent;
            this.addFoodInvoiceItemButton.color = System.Drawing.Color.Transparent;
            this.addFoodInvoiceItemButton.colorActive = System.Drawing.Color.Yellow;
            this.addFoodInvoiceItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodInvoiceItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.addFoodInvoiceItemButton.ForeColor = System.Drawing.Color.Transparent;
            this.addFoodInvoiceItemButton.Image = global::CloudDesktopApp.Properties.Resources.listadd;
            this.addFoodInvoiceItemButton.ImagePosition = 10;
            this.addFoodInvoiceItemButton.ImageZoom = 35;
            this.addFoodInvoiceItemButton.LabelPosition = 10;
            this.addFoodInvoiceItemButton.LabelText = "";
            this.addFoodInvoiceItemButton.Location = new System.Drawing.Point(43, 75);
            this.addFoodInvoiceItemButton.Margin = new System.Windows.Forms.Padding(6);
            this.addFoodInvoiceItemButton.Name = "addFoodInvoiceItemButton";
            this.addFoodInvoiceItemButton.Size = new System.Drawing.Size(51, 48);
            this.addFoodInvoiceItemButton.TabIndex = 33;
            // 
            // viewInvoiceButton
            // 
            this.viewInvoiceButton.BackColor = System.Drawing.Color.Transparent;
            this.viewInvoiceButton.color = System.Drawing.Color.Transparent;
            this.viewInvoiceButton.colorActive = System.Drawing.Color.Yellow;
            this.viewInvoiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewInvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.viewInvoiceButton.ForeColor = System.Drawing.Color.Transparent;
            this.viewInvoiceButton.Image = global::CloudDesktopApp.Properties.Resources.viewEye;
            this.viewInvoiceButton.ImagePosition = 10;
            this.viewInvoiceButton.ImageZoom = 35;
            this.viewInvoiceButton.LabelPosition = 10;
            this.viewInvoiceButton.LabelText = "";
            this.viewInvoiceButton.Location = new System.Drawing.Point(23, 113);
            this.viewInvoiceButton.Margin = new System.Windows.Forms.Padding(6);
            this.viewInvoiceButton.Name = "viewInvoiceButton";
            this.viewInvoiceButton.Size = new System.Drawing.Size(51, 38);
            this.viewInvoiceButton.TabIndex = 31;
            // 
            // unbookedTableButton
            // 
            this.unbookedTableButton.BackColor = System.Drawing.Color.Transparent;
            this.unbookedTableButton.color = System.Drawing.Color.Transparent;
            this.unbookedTableButton.colorActive = System.Drawing.Color.Yellow;
            this.unbookedTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unbookedTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.unbookedTableButton.ForeColor = System.Drawing.Color.Transparent;
            this.unbookedTableButton.Image = global::CloudDesktopApp.Properties.Resources.bookedIcon;
            this.unbookedTableButton.ImagePosition = 10;
            this.unbookedTableButton.ImageZoom = 35;
            this.unbookedTableButton.LabelPosition = 10;
            this.unbookedTableButton.LabelText = "";
            this.unbookedTableButton.Location = new System.Drawing.Point(0, 75);
            this.unbookedTableButton.Margin = new System.Windows.Forms.Padding(6);
            this.unbookedTableButton.Name = "unbookedTableButton";
            this.unbookedTableButton.Size = new System.Drawing.Size(56, 48);
            this.unbookedTableButton.TabIndex = 30;
            this.unbookedTableButton.Click += new System.EventHandler(this.unbookedTableButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.bookedTable;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 60);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Booked";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BookedHotelTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.addFoodInvoiceItemButton);
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.viewInvoiceButton);
            this.Controls.Add(this.unbookedTableButton);
            this.Controls.Add(this.materialLabel1);
            this.Name = "BookedHotelTableControl";
            this.Size = new System.Drawing.Size(93, 149);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuTileButton unbookedTableButton;
        private Bunifu.Framework.UI.BunifuTileButton viewInvoiceButton;
        private MaterialSkin.Controls.MaterialLabel tableNumber;
        private Bunifu.Framework.UI.BunifuTileButton addFoodInvoiceItemButton;
    }
}
