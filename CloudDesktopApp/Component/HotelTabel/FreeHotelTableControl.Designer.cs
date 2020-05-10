namespace CloudDesktopApp.Component.HotelTabel
{
    partial class FreeHotelTableControl
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
            this.freeTableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.editTableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.Depth = 0;
            this.tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableNumber.Location = new System.Drawing.Point(40, 60);
            this.tableNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(16, 18);
            this.tableNumber.TabIndex = 36;
            this.tableNumber.Text = "0";
            // 
            // freeTableButton
            // 
            this.freeTableButton.BackColor = System.Drawing.Color.Transparent;
            this.freeTableButton.color = System.Drawing.Color.Transparent;
            this.freeTableButton.colorActive = System.Drawing.Color.Yellow;
            this.freeTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.freeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.freeTableButton.ForeColor = System.Drawing.Color.Transparent;
            this.freeTableButton.Image = global::CloudDesktopApp.Properties.Resources.delete;
            this.freeTableButton.ImagePosition = 10;
            this.freeTableButton.ImageZoom = 35;
            this.freeTableButton.LabelPosition = 10;
            this.freeTableButton.LabelText = "";
            this.freeTableButton.Location = new System.Drawing.Point(44, 85);
            this.freeTableButton.Margin = new System.Windows.Forms.Padding(6);
            this.freeTableButton.Name = "freeTableButton";
            this.freeTableButton.Size = new System.Drawing.Size(51, 36);
            this.freeTableButton.TabIndex = 35;
            // 
            // editTableButton
            // 
            this.editTableButton.BackColor = System.Drawing.Color.Transparent;
            this.editTableButton.color = System.Drawing.Color.Transparent;
            this.editTableButton.colorActive = System.Drawing.Color.Yellow;
            this.editTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.editTableButton.ForeColor = System.Drawing.Color.Transparent;
            this.editTableButton.Image = global::CloudDesktopApp.Properties.Resources.edit;
            this.editTableButton.ImagePosition = 10;
            this.editTableButton.ImageZoom = 35;
            this.editTableButton.LabelPosition = 10;
            this.editTableButton.LabelText = "";
            this.editTableButton.Location = new System.Drawing.Point(0, 85);
            this.editTableButton.Margin = new System.Windows.Forms.Padding(6);
            this.editTableButton.Name = "editTableButton";
            this.editTableButton.Size = new System.Drawing.Size(42, 36);
            this.editTableButton.TabIndex = 34;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.freeTable;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 60);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Free";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FreeHotelTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.freeTableButton);
            this.Controls.Add(this.editTableButton);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FreeHotelTableControl";
            this.Size = new System.Drawing.Size(90, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel tableNumber;
        private Bunifu.Framework.UI.BunifuTileButton freeTableButton;
        private Bunifu.Framework.UI.BunifuTileButton editTableButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
