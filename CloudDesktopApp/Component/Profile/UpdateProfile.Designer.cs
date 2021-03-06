﻿namespace CloudDesktopApp.Component.Profile
{
    partial class UpdateProfile
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.updateProfileButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.profileName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.profileType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 185);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(247, 8);
            this.progressBar.TabIndex = 19;
            this.progressBar.Visible = false;
            // 
            // updateProfileButton
            // 
            this.updateProfileButton.AutoSize = true;
            this.updateProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateProfileButton.Depth = 0;
            this.updateProfileButton.Location = new System.Drawing.Point(73, 138);
            this.updateProfileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateProfileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateProfileButton.Name = "updateProfileButton";
            this.updateProfileButton.Primary = true;
            this.updateProfileButton.Size = new System.Drawing.Size(121, 36);
            this.updateProfileButton.TabIndex = 18;
            this.updateProfileButton.Text = "Update Profile";
            this.updateProfileButton.UseVisualStyleBackColor = true;
            this.updateProfileButton.Click += new System.EventHandler(this.updateProfileButton_Click);
            // 
            // profileName
            // 
            this.profileName.Depth = 0;
            this.profileName.Hint = "Enter the profile name";
            this.profileName.Location = new System.Drawing.Point(10, 104);
            this.profileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileName.Name = "profileName";
            this.profileName.PasswordChar = '\0';
            this.profileName.SelectedText = "";
            this.profileName.SelectionLength = 0;
            this.profileName.SelectionStart = 0;
            this.profileName.Size = new System.Drawing.Size(247, 23);
            this.profileName.TabIndex = 17;
            this.profileName.UseSystemPasswordChar = false;
            // 
            // profileType
            // 
            this.profileType.Depth = 0;
            this.profileType.Enabled = false;
            this.profileType.Hint = "Enter the profile Type";
            this.profileType.Location = new System.Drawing.Point(10, 70);
            this.profileType.MouseState = MaterialSkin.MouseState.HOVER;
            this.profileType.Name = "profileType";
            this.profileType.PasswordChar = '\0';
            this.profileType.SelectedText = "";
            this.profileType.SelectionLength = 0;
            this.profileType.SelectionStart = 0;
            this.profileType.Size = new System.Drawing.Size(247, 23);
            this.profileType.TabIndex = 20;
            this.profileType.UseSystemPasswordChar = false;
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 202);
            this.Controls.Add(this.profileType);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.updateProfileButton);
            this.Controls.Add(this.profileName);
            this.Name = "UpdateProfile";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update User Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private MaterialSkin.Controls.MaterialFlatButton updateProfileButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField profileName;
        private MaterialSkin.Controls.MaterialSingleLineTextField profileType;
    }
}