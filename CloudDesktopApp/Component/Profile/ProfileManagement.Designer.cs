namespace CloudDesktopApp.Component.Profile
{
    partial class ProfileManagement
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
            this.profilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profileCreate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.profileFormCard = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.noOfHotelTables = new MaterialSkin.Controls.MaterialLabel();
            this.noOfFood = new MaterialSkin.Controls.MaterialLabel();
            this.noOfCustomer = new MaterialSkin.Controls.MaterialLabel();
            this.profileTypeLable = new MaterialSkin.Controls.MaterialLabel();
            this.profileNameLable = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.profileTextLable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.profileFormCard.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.AutoScroll = true;
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.profilePanel.Location = new System.Drawing.Point(238, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(1045, 611);
            this.profilePanel.TabIndex = 2;
            // 
            // profileCreate
            // 
            this.profileCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileCreate.Depth = 0;
            this.profileCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileCreate.Image = global::CloudDesktopApp.Properties.Resources.profile;
            this.profileCreate.Location = new System.Drawing.Point(61, 15);
            this.profileCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileCreate.Name = "profileCreate";
            this.profileCreate.Size = new System.Drawing.Size(119, 121);
            this.profileCreate.TabIndex = 3;
            this.profileCreate.Text = "Create Profile";
            this.profileCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.profileCreate.Click += new System.EventHandler(this.profileCreate_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "User Profile Management";
            // 
            // profileFormCard
            // 
            this.profileFormCard.BackColor = System.Drawing.Color.White;
            this.profileFormCard.BorderRadius = 5;
            this.profileFormCard.BottomSahddow = true;
            this.profileFormCard.color = System.Drawing.Color.Tomato;
            this.profileFormCard.Controls.Add(this.bunifuCards2);
            this.profileFormCard.Controls.Add(this.bunifuCustomLabel1);
            this.profileFormCard.Controls.Add(this.profileCreate);
            this.profileFormCard.Controls.Add(this.profilePanel);
            this.profileFormCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profileFormCard.LeftSahddow = false;
            this.profileFormCard.Location = new System.Drawing.Point(0, 119);
            this.profileFormCard.Name = "profileFormCard";
            this.profileFormCard.RightSahddow = true;
            this.profileFormCard.ShadowDepth = 20;
            this.profileFormCard.Size = new System.Drawing.Size(1283, 611);
            this.profileFormCard.TabIndex = 15;
            this.profileFormCard.Visible = false;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.Chartreuse;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Black;
            this.bunifuCards2.Controls.Add(this.noOfHotelTables);
            this.bunifuCards2.Controls.Add(this.noOfFood);
            this.bunifuCards2.Controls.Add(this.noOfCustomer);
            this.bunifuCards2.Controls.Add(this.profileTypeLable);
            this.bunifuCards2.Controls.Add(this.profileNameLable);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 191);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(235, 189);
            this.bunifuCards2.TabIndex = 17;
            // 
            // noOfHotelTables
            // 
            this.noOfHotelTables.AutoSize = true;
            this.noOfHotelTables.Depth = 0;
            this.noOfHotelTables.Font = new System.Drawing.Font("Roboto", 11F);
            this.noOfHotelTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noOfHotelTables.Location = new System.Drawing.Point(135, 137);
            this.noOfHotelTables.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOfHotelTables.Name = "noOfHotelTables";
            this.noOfHotelTables.Size = new System.Drawing.Size(17, 19);
            this.noOfHotelTables.TabIndex = 27;
            this.noOfHotelTables.Text = "0";
            // 
            // noOfFood
            // 
            this.noOfFood.AutoSize = true;
            this.noOfFood.Depth = 0;
            this.noOfFood.Font = new System.Drawing.Font("Roboto", 11F);
            this.noOfFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noOfFood.Location = new System.Drawing.Point(135, 107);
            this.noOfFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOfFood.Name = "noOfFood";
            this.noOfFood.Size = new System.Drawing.Size(17, 19);
            this.noOfFood.TabIndex = 26;
            this.noOfFood.Text = "0";
            // 
            // noOfCustomer
            // 
            this.noOfCustomer.AutoSize = true;
            this.noOfCustomer.Depth = 0;
            this.noOfCustomer.Font = new System.Drawing.Font("Roboto", 11F);
            this.noOfCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noOfCustomer.Location = new System.Drawing.Point(135, 79);
            this.noOfCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOfCustomer.Name = "noOfCustomer";
            this.noOfCustomer.Size = new System.Drawing.Size(17, 19);
            this.noOfCustomer.TabIndex = 25;
            this.noOfCustomer.Text = "0";
            // 
            // profileTypeLable
            // 
            this.profileTypeLable.AutoSize = true;
            this.profileTypeLable.Depth = 0;
            this.profileTypeLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileTypeLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileTypeLable.Location = new System.Drawing.Point(120, 49);
            this.profileTypeLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileTypeLable.Name = "profileTypeLable";
            this.profileTypeLable.Size = new System.Drawing.Size(54, 19);
            this.profileTypeLable.TabIndex = 24;
            this.profileTypeLable.Text = "XXXXX";
            // 
            // profileNameLable
            // 
            this.profileNameLable.AutoSize = true;
            this.profileNameLable.Depth = 0;
            this.profileNameLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.profileNameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.profileNameLable.Location = new System.Drawing.Point(120, 21);
            this.profileNameLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileNameLable.Name = "profileNameLable";
            this.profileNameLable.Size = new System.Drawing.Size(54, 19);
            this.profileNameLable.TabIndex = 23;
            this.profileNameLable.Text = "XXXXX";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 137);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(126, 17);
            this.bunifuCustomLabel6.TabIndex = 22;
            this.bunifuCustomLabel6.Text = "Total hotel tables:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(3, 109);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(78, 17);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "Total food:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(3, 80);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(111, 17);
            this.bunifuCustomLabel4.TabIndex = 20;
            this.bunifuCustomLabel4.Text = "Total customer:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 49);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "Profile type:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 21);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Profile name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 157);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(207, 19);
            this.bunifuCustomLabel1.TabIndex = 16;
            this.bunifuCustomLabel1.Text = "Current Active Profile Details";
            // 
            // profileTextLable
            // 
            this.profileTextLable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.profileTextLable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.profileTextLable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileTextLable.BorderRadius = 0;
            this.profileTextLable.ButtonText = "All Profile Details";
            this.profileTextLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileTextLable.DisabledColor = System.Drawing.Color.Black;
            this.profileTextLable.Iconcolor = System.Drawing.Color.Transparent;
            this.profileTextLable.Iconimage = null;
            this.profileTextLable.Iconimage_right = null;
            this.profileTextLable.Iconimage_right_Selected = null;
            this.profileTextLable.Iconimage_Selected = null;
            this.profileTextLable.IconMarginLeft = 0;
            this.profileTextLable.IconMarginRight = 0;
            this.profileTextLable.IconRightVisible = false;
            this.profileTextLable.IconRightZoom = 0D;
            this.profileTextLable.IconVisible = false;
            this.profileTextLable.IconZoom = 90D;
            this.profileTextLable.IsTab = true;
            this.profileTextLable.Location = new System.Drawing.Point(238, 81);
            this.profileTextLable.Name = "profileTextLable";
            this.profileTextLable.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.profileTextLable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.profileTextLable.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.profileTextLable.selected = false;
            this.profileTextLable.Size = new System.Drawing.Size(131, 32);
            this.profileTextLable.TabIndex = 14;
            this.profileTextLable.Text = "All Profile Details";
            this.profileTextLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.profileTextLable.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(166)))), ((int)(((byte)(171)))));
            this.profileTextLable.TextFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileTextLable.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(447, 103);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(487, 10);
            this.progressBar.TabIndex = 16;
            this.progressBar.Visible = false;
            // 
            // ProfileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 730);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.profileFormCard);
            this.Controls.Add(this.profileTextLable);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileManagement";
            this.Text = "ProfileManagement";
            this.Load += new System.EventHandler(this.ProfileManagement_Load);
            this.profileFormCard.ResumeLayout(false);
            this.profileFormCard.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel profilePanel;
        private MaterialSkin.Controls.MaterialLabel profileCreate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuCards profileFormCard;
        private Bunifu.Framework.UI.BunifuFlatButton profileTextLable;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private MaterialSkin.Controls.MaterialLabel noOfHotelTables;
        private MaterialSkin.Controls.MaterialLabel noOfFood;
        private MaterialSkin.Controls.MaterialLabel noOfCustomer;
        private MaterialSkin.Controls.MaterialLabel profileTypeLable;
        private MaterialSkin.Controls.MaterialLabel profileNameLable;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}