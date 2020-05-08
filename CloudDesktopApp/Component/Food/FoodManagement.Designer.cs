namespace CloudDesktopApp.Component.Food
{
    partial class FoodManagement
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
            this.foodCreate = new MaterialSkin.Controls.MaterialLabel();
            this.foodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 23);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Foods Management";
            // 
            // foodCreate
            // 
            this.foodCreate.BackColor = System.Drawing.Color.Lime;
            this.foodCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodCreate.Depth = 0;
            this.foodCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.foodCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.foodCreate.Image = global::CloudDesktopApp.Properties.Resources.foods;
            this.foodCreate.Location = new System.Drawing.Point(12, 113);
            this.foodCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.foodCreate.Name = "foodCreate";
            this.foodCreate.Size = new System.Drawing.Size(119, 121);
            this.foodCreate.TabIndex = 5;
            this.foodCreate.Text = "Add Food";
            this.foodCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.foodCreate.Click += new System.EventHandler(this.foodCreate_Click);
            // 
            // foodPanel
            // 
            this.foodPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.foodPanel.Location = new System.Drawing.Point(263, 0);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(773, 430);
            this.foodPanel.TabIndex = 6;
            // 
            // FoodManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 430);
            this.Controls.Add(this.foodPanel);
            this.Controls.Add(this.foodCreate);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodManagement";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.FoodManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel foodCreate;
        private System.Windows.Forms.FlowLayoutPanel foodPanel;
    }
}