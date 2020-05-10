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
            this.bookedTablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.freeTablesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // bookedTablesPanel
            // 
            this.bookedTablesPanel.AutoScroll = true;
            this.bookedTablesPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bookedTablesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookedTablesPanel.Location = new System.Drawing.Point(0, 289);
            this.bookedTablesPanel.Name = "bookedTablesPanel";
            this.bookedTablesPanel.Size = new System.Drawing.Size(586, 274);
            this.bookedTablesPanel.TabIndex = 12;
            // 
            // freeTablesPanel
            // 
            this.freeTablesPanel.AutoScroll = true;
            this.freeTablesPanel.BackColor = System.Drawing.Color.DimGray;
            this.freeTablesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.freeTablesPanel.Location = new System.Drawing.Point(0, 0);
            this.freeTablesPanel.Name = "freeTablesPanel";
            this.freeTablesPanel.Size = new System.Drawing.Size(586, 283);
            this.freeTablesPanel.TabIndex = 11;
            // 
            // TableStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookedTablesPanel);
            this.Controls.Add(this.freeTablesPanel);
            this.Name = "TableStatusControl";
            this.Size = new System.Drawing.Size(586, 563);
            this.Load += new System.EventHandler(this.TableStatusControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bookedTablesPanel;
        private System.Windows.Forms.FlowLayoutPanel freeTablesPanel;
    }
}
