namespace CloudDesktopApp.Component.MainTable
{
    partial class TableStatusControl
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
            this.bookedTables = new System.Windows.Forms.FlowLayoutPanel();
            this.freeTables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // bookedTables
            // 
            this.bookedTables.AutoScroll = true;
            this.bookedTables.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookedTables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookedTables.Location = new System.Drawing.Point(0, 289);
            this.bookedTables.Name = "bookedTables";
            this.bookedTables.Size = new System.Drawing.Size(586, 274);
            this.bookedTables.TabIndex = 12;
            // 
            // freeTables
            // 
            this.freeTables.AutoScroll = true;
            this.freeTables.BackColor = System.Drawing.Color.DimGray;
            this.freeTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.freeTables.Location = new System.Drawing.Point(0, 0);
            this.freeTables.Name = "freeTables";
            this.freeTables.Size = new System.Drawing.Size(586, 283);
            this.freeTables.TabIndex = 11;
            // 
            // TableStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookedTables);
            this.Controls.Add(this.freeTables);
            this.Name = "TableStatusControl";
            this.Size = new System.Drawing.Size(586, 563);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bookedTables;
        private System.Windows.Forms.FlowLayoutPanel freeTables;
    }
}
