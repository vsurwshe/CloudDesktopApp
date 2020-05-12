namespace CloudDesktopApp.Component.MainTable
{
    partial class MainTableManagement
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
            this.hotelTablesPanle = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // hotelTablesPanle
            // 
            this.hotelTablesPanle.AutoScroll = true;
            this.hotelTablesPanle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hotelTablesPanle.BackColor = System.Drawing.Color.Transparent;
            this.hotelTablesPanle.Dock = System.Windows.Forms.DockStyle.Right;
            this.hotelTablesPanle.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.hotelTablesPanle.Location = new System.Drawing.Point(227, 0);
            this.hotelTablesPanle.Name = "hotelTablesPanle";
            this.hotelTablesPanle.Size = new System.Drawing.Size(730, 788);
            this.hotelTablesPanle.TabIndex = 1;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(167, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Daily Table Transcation";
            // 
            // MainTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 788);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.hotelTablesPanle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTableManagement";
            this.Text = "MainTable";
            this.Load += new System.EventHandler(this.MainTableManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel hotelTablesPanle;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}