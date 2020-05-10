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
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.tableLocations = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.invoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelTablesPanle
            // 
            this.hotelTablesPanle.AutoScroll = true;
            this.hotelTablesPanle.AutoSize = true;
            this.hotelTablesPanle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hotelTablesPanle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hotelTablesPanle.Dock = System.Windows.Forms.DockStyle.Left;
            this.hotelTablesPanle.Location = new System.Drawing.Point(0, 0);
            this.hotelTablesPanle.Name = "hotelTablesPanle";
            this.hotelTablesPanle.Size = new System.Drawing.Size(0, 788);
            this.hotelTablesPanle.TabIndex = 1;
            // 
            // invoicePanel
            // 
            this.invoicePanel.AutoSize = true;
            this.invoicePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.invoicePanel.BackColor = System.Drawing.SystemColors.Info;
            this.invoicePanel.Controls.Add(this.tableLocations);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.invoicePanel.Location = new System.Drawing.Point(820, 0);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(137, 788);
            this.invoicePanel.TabIndex = 2;
            // 
            // tableLocations
            // 
            this.tableLocations.AutoSize = true;
            this.tableLocations.Depth = 0;
            this.tableLocations.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLocations.Location = new System.Drawing.Point(134, 150);
            this.tableLocations.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableLocations.Name = "tableLocations";
            this.tableLocations.Size = new System.Drawing.Size(0, 19);
            this.tableLocations.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(592, 1);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(56, 24);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Daily";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(592, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(122, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Transcations";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(592, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 24);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Table";
            // 
            // MainTableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 788);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.invoicePanel);
            this.Controls.Add(this.hotelTablesPanle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainTableManagement";
            this.Text = "MainTable";
            this.Load += new System.EventHandler(this.MainTableManagement_Load);
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel hotelTablesPanle;
        private System.Windows.Forms.Panel invoicePanel;
        private MaterialSkin.Controls.MaterialLabel tableLocations;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}