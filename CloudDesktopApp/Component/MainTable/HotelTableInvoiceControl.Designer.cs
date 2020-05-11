namespace CloudDesktopApp.Component.MainTable
{
    partial class HotelTableInvoiceControl
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
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonPanle = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.date = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.customerName = new MaterialSkin.Controls.MaterialLabel();
            this.customerNameInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tableLocations = new MaterialSkin.Controls.MaterialLabel();
            this.tabelLocationInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tabelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.tableNumberInfoLable = new MaterialSkin.Controls.MaterialLabel();
            this.saveInvoiceButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.invoiceItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.invoicePanel.SuspendLayout();
            this.buttonPanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoicePanel
            // 
            this.invoicePanel.BackColor = System.Drawing.SystemColors.Info;
            this.invoicePanel.Controls.Add(this.materialLabel1);
            this.invoicePanel.Controls.Add(this.buttonPanle);
            this.invoicePanel.Controls.Add(this.date);
            this.invoicePanel.Controls.Add(this.materialLabel3);
            this.invoicePanel.Controls.Add(this.customerName);
            this.invoicePanel.Controls.Add(this.customerNameInfoLabel);
            this.invoicePanel.Controls.Add(this.tableLocations);
            this.invoicePanel.Controls.Add(this.tabelLocationInfoLabel);
            this.invoicePanel.Controls.Add(this.tabelNumber);
            this.invoicePanel.Controls.Add(this.tableNumberInfoLable);
            this.invoicePanel.Controls.Add(this.saveInvoiceButton);
            this.invoicePanel.Controls.Add(this.invoiceItemPanel);
            this.invoicePanel.Controls.Add(this.shapeContainer1);
            this.invoicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicePanel.Location = new System.Drawing.Point(0, 0);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(586, 563);
            this.invoicePanel.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 149);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Customer Invoice Order Items";
            // 
            // buttonPanle
            // 
            this.buttonPanle.Controls.Add(this.materialFlatButton1);
            this.buttonPanle.Location = new System.Drawing.Point(6, 518);
            this.buttonPanle.Name = "buttonPanle";
            this.buttonPanle.Size = new System.Drawing.Size(577, 42);
            this.buttonPanle.TabIndex = 13;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(455, 3);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(102, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Save Invoice";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Depth = 0;
            this.date.Dock = System.Windows.Forms.DockStyle.Left;
            this.date.Font = new System.Drawing.Font("Roboto", 11F);
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.date.Location = new System.Drawing.Point(44, 0);
            this.date.MouseState = MaterialSkin.MouseState.HOVER;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(85, 19);
            this.date.TabIndex = 12;
            this.date.Text = "23/06/2020";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(0, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(44, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Date:";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Depth = 0;
            this.customerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerName.Location = new System.Drawing.Point(133, 111);
            this.customerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(116, 19);
            this.customerName.TabIndex = 8;
            this.customerName.Text = "Mr. Vishva Baby";
            // 
            // customerNameInfoLabel
            // 
            this.customerNameInfoLabel.AutoSize = true;
            this.customerNameInfoLabel.Depth = 0;
            this.customerNameInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerNameInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerNameInfoLabel.Location = new System.Drawing.Point(2, 111);
            this.customerNameInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerNameInfoLabel.Name = "customerNameInfoLabel";
            this.customerNameInfoLabel.Size = new System.Drawing.Size(131, 19);
            this.customerNameInfoLabel.TabIndex = 7;
            this.customerNameInfoLabel.Text = "Customer Name : ";
            // 
            // tableLocations
            // 
            this.tableLocations.AutoSize = true;
            this.tableLocations.Depth = 0;
            this.tableLocations.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLocations.Location = new System.Drawing.Point(133, 73);
            this.tableLocations.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableLocations.Name = "tableLocations";
            this.tableLocations.Size = new System.Drawing.Size(48, 19);
            this.tableLocations.TabIndex = 6;
            this.tableLocations.Text = "South";
            // 
            // tabelLocationInfoLabel
            // 
            this.tabelLocationInfoLabel.AutoSize = true;
            this.tabelLocationInfoLabel.Depth = 0;
            this.tabelLocationInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tabelLocationInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabelLocationInfoLabel.Location = new System.Drawing.Point(2, 73);
            this.tabelLocationInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabelLocationInfoLabel.Name = "tabelLocationInfoLabel";
            this.tabelLocationInfoLabel.Size = new System.Drawing.Size(125, 19);
            this.tabelLocationInfoLabel.TabIndex = 5;
            this.tabelLocationInfoLabel.Text = "Tabel Locations :";
            // 
            // tabelNumber
            // 
            this.tabelNumber.AutoSize = true;
            this.tabelNumber.Depth = 0;
            this.tabelNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.tabelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabelNumber.Location = new System.Drawing.Point(133, 31);
            this.tabelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabelNumber.Name = "tabelNumber";
            this.tabelNumber.Size = new System.Drawing.Size(17, 19);
            this.tabelNumber.TabIndex = 4;
            this.tabelNumber.Text = "5";
            // 
            // tableNumberInfoLable
            // 
            this.tableNumberInfoLable.AutoSize = true;
            this.tableNumberInfoLable.Depth = 0;
            this.tableNumberInfoLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableNumberInfoLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableNumberInfoLable.Location = new System.Drawing.Point(2, 31);
            this.tableNumberInfoLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableNumberInfoLable.Name = "tableNumberInfoLable";
            this.tableNumberInfoLable.Size = new System.Drawing.Size(111, 19);
            this.tableNumberInfoLable.TabIndex = 3;
            this.tableNumberInfoLable.Text = "Tabel Number :";
            // 
            // saveInvoiceButton
            // 
            this.saveInvoiceButton.AutoSize = true;
            this.saveInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveInvoiceButton.Depth = 0;
            this.saveInvoiceButton.Location = new System.Drawing.Point(332, 660);
            this.saveInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveInvoiceButton.Name = "saveInvoiceButton";
            this.saveInvoiceButton.Primary = true;
            this.saveInvoiceButton.Size = new System.Drawing.Size(102, 36);
            this.saveInvoiceButton.TabIndex = 1;
            this.saveInvoiceButton.Text = "Save Invoice";
            this.saveInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // invoiceItemPanel
            // 
            this.invoiceItemPanel.BackColor = System.Drawing.Color.White;
            this.invoiceItemPanel.Location = new System.Drawing.Point(4, 180);
            this.invoiceItemPanel.Name = "invoiceItemPanel";
            this.invoiceItemPanel.Size = new System.Drawing.Size(582, 332);
            this.invoiceItemPanel.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(586, 563);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -2;
            this.lineShape2.X2 = 587;
            this.lineShape2.Y1 = 25;
            this.lineShape2.Y2 = 25;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 585;
            this.lineShape1.Y1 = 139;
            this.lineShape1.Y2 = 139;
            // 
            // HotelTableInvoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.invoicePanel);
            this.Name = "HotelTableInvoiceControl";
            this.Size = new System.Drawing.Size(586, 563);
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.buttonPanle.ResumeLayout(false);
            this.buttonPanle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel invoicePanel;
        private MaterialSkin.Controls.MaterialLabel date;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel customerName;
        private MaterialSkin.Controls.MaterialLabel customerNameInfoLabel;
        private MaterialSkin.Controls.MaterialLabel tableLocations;
        private MaterialSkin.Controls.MaterialLabel tabelLocationInfoLabel;
        private MaterialSkin.Controls.MaterialLabel tabelNumber;
        private MaterialSkin.Controls.MaterialLabel tableNumberInfoLable;
        private MaterialSkin.Controls.MaterialFlatButton saveInvoiceButton;
        private System.Windows.Forms.FlowLayoutPanel invoiceItemPanel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel buttonPanle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
