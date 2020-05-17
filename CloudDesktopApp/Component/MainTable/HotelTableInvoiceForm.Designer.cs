namespace CloudDesktopApp.Component.MainTable
{
    partial class HotelTableInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.invoiceItemInfoPanle = new System.Windows.Forms.Panel();
            this.invoiceFoodItemDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.addFoodInvoice = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.invoiceInfoPanel = new System.Windows.Forms.Panel();
            this.customerName = new MaterialSkin.Controls.MaterialLabel();
            this.tableNumberInfoLable = new MaterialSkin.Controls.MaterialLabel();
            this.tabelNumber = new MaterialSkin.Controls.MaterialLabel();
            this.tabelLocationInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tableLocations = new MaterialSkin.Controls.MaterialLabel();
            this.customerNameInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.invoiceButtonPanle = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.invoiceItemInfoPanle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFoodItemDetails)).BeginInit();
            this.invoiceInfoPanel.SuspendLayout();
            this.invoiceButtonPanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceDate
            // 
            this.invoiceDate.AutoSize = true;
            this.invoiceDate.Depth = 0;
            this.invoiceDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.invoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.invoiceDate.Location = new System.Drawing.Point(493, 13);
            this.invoiceDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(85, 19);
            this.invoiceDate.TabIndex = 12;
            this.invoiceDate.Text = "23/06/2020";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(443, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(44, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Date:";
            // 
            // invoiceItemInfoPanle
            // 
            this.invoiceItemInfoPanle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceItemInfoPanle.Controls.Add(this.invoiceFoodItemDetails);
            this.invoiceItemInfoPanle.Controls.Add(this.addFoodInvoice);
            this.invoiceItemInfoPanle.Controls.Add(this.materialLabel1);
            this.invoiceItemInfoPanle.Location = new System.Drawing.Point(10, 238);
            this.invoiceItemInfoPanle.Name = "invoiceItemInfoPanle";
            this.invoiceItemInfoPanle.Size = new System.Drawing.Size(583, 297);
            this.invoiceItemInfoPanle.TabIndex = 16;
            this.invoiceItemInfoPanle.Visible = false;
            // 
            // invoiceFoodItemDetails
            // 
            this.invoiceFoodItemDetails.AllowUserToAddRows = false;
            this.invoiceFoodItemDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceFoodItemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceFoodItemDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.invoiceFoodItemDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceFoodItemDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invoiceFoodItemDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceFoodItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invoiceFoodItemDetails.ColumnHeadersHeight = 30;
            this.invoiceFoodItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceFoodItemDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.invoiceFoodItemDetails.DoubleBuffered = true;
            this.invoiceFoodItemDetails.EnableHeadersVisualStyles = false;
            this.invoiceFoodItemDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.HeaderBgColor = System.Drawing.Color.White;
            this.invoiceFoodItemDetails.HeaderForeColor = System.Drawing.Color.Black;
            this.invoiceFoodItemDetails.Location = new System.Drawing.Point(6, 35);
            this.invoiceFoodItemDetails.Name = "invoiceFoodItemDetails";
            this.invoiceFoodItemDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceFoodItemDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.invoiceFoodItemDetails.RowHeadersVisible = false;
            this.invoiceFoodItemDetails.RowHeadersWidth = 120;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.invoiceFoodItemDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.invoiceFoodItemDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceFoodItemDetails.RowTemplate.Height = 30;
            this.invoiceFoodItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceFoodItemDetails.Size = new System.Drawing.Size(570, 226);
            this.invoiceFoodItemDetails.TabIndex = 16;
            this.invoiceFoodItemDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceFoodItemDetails_CellContentClick);
            // 
            // addFoodInvoice
            // 
            this.addFoodInvoice.AutoSize = true;
            this.addFoodInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFoodInvoice.BackColor = System.Drawing.Color.Green;
            this.addFoodInvoice.Depth = 0;
            this.addFoodInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFoodInvoice.ForeColor = System.Drawing.Color.White;
            this.addFoodInvoice.Location = new System.Drawing.Point(488, 2);
            this.addFoodInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addFoodInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.addFoodInvoice.Name = "addFoodInvoice";
            this.addFoodInvoice.Primary = false;
            this.addFoodInvoice.Size = new System.Drawing.Size(89, 36);
            this.addFoodInvoice.TabIndex = 15;
            this.addFoodInvoice.Text = "+ Add Food";
            this.addFoodInvoice.UseVisualStyleBackColor = false;
            this.addFoodInvoice.Click += new System.EventHandler(this.addFoodInvoice_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(209, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Customer Invoice Order Items";
            // 
            // invoiceInfoPanel
            // 
            this.invoiceInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInfoPanel.Controls.Add(this.invoiceDate);
            this.invoiceInfoPanel.Controls.Add(this.materialLabel3);
            this.invoiceInfoPanel.Controls.Add(this.customerName);
            this.invoiceInfoPanel.Controls.Add(this.tableNumberInfoLable);
            this.invoiceInfoPanel.Controls.Add(this.tabelNumber);
            this.invoiceInfoPanel.Controls.Add(this.tabelLocationInfoLabel);
            this.invoiceInfoPanel.Controls.Add(this.tableLocations);
            this.invoiceInfoPanel.Controls.Add(this.customerNameInfoLabel);
            this.invoiceInfoPanel.Location = new System.Drawing.Point(10, 100);
            this.invoiceInfoPanel.Name = "invoiceInfoPanel";
            this.invoiceInfoPanel.Size = new System.Drawing.Size(583, 132);
            this.invoiceInfoPanel.TabIndex = 15;
            this.invoiceInfoPanel.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Depth = 0;
            this.customerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerName.Location = new System.Drawing.Point(140, 93);
            this.customerName.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(116, 19);
            this.customerName.TabIndex = 8;
            this.customerName.Text = "Mr. Vishva Baby";
            // 
            // tableNumberInfoLable
            // 
            this.tableNumberInfoLable.AutoSize = true;
            this.tableNumberInfoLable.Depth = 0;
            this.tableNumberInfoLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableNumberInfoLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableNumberInfoLable.Location = new System.Drawing.Point(3, 13);
            this.tableNumberInfoLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableNumberInfoLable.Name = "tableNumberInfoLable";
            this.tableNumberInfoLable.Size = new System.Drawing.Size(111, 19);
            this.tableNumberInfoLable.TabIndex = 3;
            this.tableNumberInfoLable.Text = "Tabel Number :";
            // 
            // tabelNumber
            // 
            this.tabelNumber.AutoSize = true;
            this.tabelNumber.Depth = 0;
            this.tabelNumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.tabelNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabelNumber.Location = new System.Drawing.Point(140, 13);
            this.tabelNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabelNumber.Name = "tabelNumber";
            this.tabelNumber.Size = new System.Drawing.Size(17, 19);
            this.tabelNumber.TabIndex = 4;
            this.tabelNumber.Text = "5";
            // 
            // tabelLocationInfoLabel
            // 
            this.tabelLocationInfoLabel.AutoSize = true;
            this.tabelLocationInfoLabel.Depth = 0;
            this.tabelLocationInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tabelLocationInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabelLocationInfoLabel.Location = new System.Drawing.Point(3, 55);
            this.tabelLocationInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabelLocationInfoLabel.Name = "tabelLocationInfoLabel";
            this.tabelLocationInfoLabel.Size = new System.Drawing.Size(125, 19);
            this.tabelLocationInfoLabel.TabIndex = 5;
            this.tabelLocationInfoLabel.Text = "Tabel Locations :";
            // 
            // tableLocations
            // 
            this.tableLocations.AutoSize = true;
            this.tableLocations.Depth = 0;
            this.tableLocations.Font = new System.Drawing.Font("Roboto", 11F);
            this.tableLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLocations.Location = new System.Drawing.Point(140, 55);
            this.tableLocations.MouseState = MaterialSkin.MouseState.HOVER;
            this.tableLocations.Name = "tableLocations";
            this.tableLocations.Size = new System.Drawing.Size(48, 19);
            this.tableLocations.TabIndex = 6;
            this.tableLocations.Text = "South";
            // 
            // customerNameInfoLabel
            // 
            this.customerNameInfoLabel.AutoSize = true;
            this.customerNameInfoLabel.Depth = 0;
            this.customerNameInfoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerNameInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerNameInfoLabel.Location = new System.Drawing.Point(3, 93);
            this.customerNameInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerNameInfoLabel.Name = "customerNameInfoLabel";
            this.customerNameInfoLabel.Size = new System.Drawing.Size(131, 19);
            this.customerNameInfoLabel.TabIndex = 7;
            this.customerNameInfoLabel.Text = "Customer Name : ";
            // 
            // invoiceButtonPanle
            // 
            this.invoiceButtonPanle.Controls.Add(this.materialFlatButton1);
            this.invoiceButtonPanle.Location = new System.Drawing.Point(10, 541);
            this.invoiceButtonPanle.Name = "invoiceButtonPanle";
            this.invoiceButtonPanle.Size = new System.Drawing.Size(586, 52);
            this.invoiceButtonPanle.TabIndex = 13;
            this.invoiceButtonPanle.Visible = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(477, 6);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(102, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Save Invoice";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // HotelTableInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 605);
            this.Controls.Add(this.invoiceButtonPanle);
            this.Controls.Add(this.invoiceItemInfoPanle);
            this.Controls.Add(this.invoiceInfoPanel);
            this.Name = "HotelTableInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.invoiceItemInfoPanle.ResumeLayout(false);
            this.invoiceItemInfoPanle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFoodItemDetails)).EndInit();
            this.invoiceInfoPanel.ResumeLayout(false);
            this.invoiceInfoPanel.PerformLayout();
            this.invoiceButtonPanle.ResumeLayout(false);
            this.invoiceButtonPanle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel invoiceDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel customerName;
        private MaterialSkin.Controls.MaterialLabel customerNameInfoLabel;
        private MaterialSkin.Controls.MaterialLabel tableLocations;
        private MaterialSkin.Controls.MaterialLabel tabelLocationInfoLabel;
        private MaterialSkin.Controls.MaterialLabel tabelNumber;
        private MaterialSkin.Controls.MaterialLabel tableNumberInfoLable;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel invoiceButtonPanle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel invoiceInfoPanel;
        private System.Windows.Forms.Panel invoiceItemInfoPanle;
        private MaterialSkin.Controls.MaterialFlatButton addFoodInvoice;
        private Bunifu.Framework.UI.BunifuCustomDataGrid invoiceFoodItemDetails;
    }
}
