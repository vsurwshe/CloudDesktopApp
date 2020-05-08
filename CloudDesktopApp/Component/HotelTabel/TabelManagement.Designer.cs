namespace CloudDesktopApp.Component.HotelTabel
{
    partial class Tabel
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.hotelTablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hotelTableCreate = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(1, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(170, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Hotel Tabel Managment";
            // 
            // hotelTablePanel
            // 
            this.hotelTablePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotelTablePanel.Location = new System.Drawing.Point(415, 0);
            this.hotelTablePanel.Name = "hotelTablePanel";
            this.hotelTablePanel.Size = new System.Drawing.Size(570, 376);
            this.hotelTablePanel.TabIndex = 6;
            // 
            // hotelTableCreate
            // 
            this.hotelTableCreate.BackColor = System.Drawing.Color.Lime;
            this.hotelTableCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotelTableCreate.Depth = 0;
            this.hotelTableCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.hotelTableCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hotelTableCreate.Image = global::CloudDesktopApp.Properties.Resources.restaurant_table;
            this.hotelTableCreate.Location = new System.Drawing.Point(23, 114);
            this.hotelTableCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.hotelTableCreate.Name = "hotelTableCreate";
            this.hotelTableCreate.Size = new System.Drawing.Size(119, 121);
            this.hotelTableCreate.TabIndex = 7;
            this.hotelTableCreate.Text = "Add Hotel Table";
            this.hotelTableCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotelTableCreate.Click += new System.EventHandler(this.hotelTableCreate_Click);
            // 
            // Tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 376);
            this.Controls.Add(this.hotelTableCreate);
            this.Controls.Add(this.hotelTablePanel);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tabel";
            this.Text = "Tabel";
            this.Load += new System.EventHandler(this.Tabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FlowLayoutPanel hotelTablePanel;
        private MaterialSkin.Controls.MaterialLabel hotelTableCreate;
    }
}