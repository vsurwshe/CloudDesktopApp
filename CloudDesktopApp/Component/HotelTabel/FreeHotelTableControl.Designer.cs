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
            this.bookTableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // tableNumber
            // 
            this.tableNumber.AutoSize = true;
            this.tableNumber.Depth = 0;
            this.tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tableNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableNumber.Location = new System.Drawing.Point(13, 60);
            this.tableNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableNumber.Name = "tableNumber";
            this.tableNumber.Size = new System.Drawing.Size(16, 18);
            this.tableNumber.TabIndex = 36;
            this.tableNumber.Text = "0";
            this.tableNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookTableButton
            // 
            this.bookTableButton.BackColor = System.Drawing.Color.Transparent;
            this.bookTableButton.color = System.Drawing.Color.Transparent;
            this.bookTableButton.colorActive = System.Drawing.Color.Yellow;
            this.bookTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bookTableButton.ForeColor = System.Drawing.Color.Transparent;
            this.bookTableButton.Image = global::CloudDesktopApp.Properties.Resources.freeIcon;
            this.bookTableButton.ImagePosition = 10;
            this.bookTableButton.ImageZoom = 35;
            this.bookTableButton.LabelPosition = 10;
            this.bookTableButton.LabelText = "";
            this.bookTableButton.Location = new System.Drawing.Point(-1, 74);
            this.bookTableButton.Margin = new System.Windows.Forms.Padding(6);
            this.bookTableButton.Name = "bookTableButton";
            this.bookTableButton.Size = new System.Drawing.Size(77, 43);
            this.bookTableButton.TabIndex = 34;
            this.bookTableButton.Click += new System.EventHandler(this.bookTableButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Image = global::CloudDesktopApp.Properties.Resources.freeTable;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 60);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Free";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FreeHotelTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableNumber);
            this.Controls.Add(this.bookTableButton);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FreeHotelTableControl";
            this.Size = new System.Drawing.Size(76, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel tableNumber;
        private Bunifu.Framework.UI.BunifuTileButton bookTableButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
