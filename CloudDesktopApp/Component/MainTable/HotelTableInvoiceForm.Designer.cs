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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoiceDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.invoiceItemInfoPanle = new System.Windows.Forms.Panel();
            this.totalAmountLable = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
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
            this.saveInvoiceButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.invoiceNumberLable = new MaterialSkin.Controls.MaterialLabel();
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
            this.invoiceDate.Location = new System.Drawing.Point(492, 7);
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
            this.materialLabel3.Location = new System.Drawing.Point(442, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(44, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Date:";
            // 
            // invoiceItemInfoPanle
            // 
            this.invoiceItemInfoPanle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceItemInfoPanle.Controls.Add(this.totalAmountLable);
            this.invoiceItemInfoPanle.Controls.Add(this.materialLabel2);
            this.invoiceItemInfoPanle.Controls.Add(this.invoiceFoodItemDetails);
            this.invoiceItemInfoPanle.Controls.Add(this.addFoodInvoice);
            this.invoiceItemInfoPanle.Controls.Add(this.materialLabel1);
            this.invoiceItemInfoPanle.Location = new System.Drawing.Point(7, 177);
            this.invoiceItemInfoPanle.Name = "invoiceItemInfoPanle";
            this.invoiceItemInfoPanle.Size = new System.Drawing.Size(583, 298);
            this.invoiceItemInfoPanle.TabIndex = 16;
            this.invoiceItemInfoPanle.Visible = false;
            // 
            // totalAmountLable
            // 
            this.totalAmountLable.AutoSize = true;
            this.totalAmountLable.Depth = 0;
            this.totalAmountLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalAmountLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalAmountLable.Location = new System.Drawing.Point(504, 268);
            this.totalAmountLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalAmountLable.Name = "totalAmountLable";
            this.totalAmountLable.Size = new System.Drawing.Size(73, 19);
            this.totalAmountLable.TabIndex = 18;
            this.totalAmountLable.Text = "00000000";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(344, 268);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(161, 19);
            this.materialLabel2.TabIndex = 17;
            this.materialLabel2.Text = "Total Invoice Amount :";
            // 
            // invoiceFoodItemDetails
            // 
            this.invoiceFoodItemDetails.AllowUserToAddRows = false;
            this.invoiceFoodItemDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.invoiceFoodItemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceFoodItemDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.invoiceFoodItemDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceFoodItemDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invoiceFoodItemDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceFoodItemDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.invoiceFoodItemDetails.ColumnHeadersHeight = 30;
            this.invoiceFoodItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceFoodItemDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.invoiceFoodItemDetails.DoubleBuffered = true;
            this.invoiceFoodItemDetails.EnableHeadersVisualStyles = false;
            this.invoiceFoodItemDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.invoiceFoodItemDetails.HeaderBgColor = System.Drawing.Color.White;
            this.invoiceFoodItemDetails.HeaderForeColor = System.Drawing.Color.Black;
            this.invoiceFoodItemDetails.Location = new System.Drawing.Point(2, 45);
            this.invoiceFoodItemDetails.Name = "invoiceFoodItemDetails";
            this.invoiceFoodItemDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invoiceFoodItemDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.invoiceFoodItemDetails.RowHeadersVisible = false;
            this.invoiceFoodItemDetails.RowHeadersWidth = 120;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.invoiceFoodItemDetails.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.invoiceFoodItemDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.invoiceFoodItemDetails.RowTemplate.Height = 30;
            this.invoiceFoodItemDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceFoodItemDetails.Size = new System.Drawing.Size(578, 214);
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
            this.addFoodInvoice.Location = new System.Drawing.Point(453, 4);
            this.addFoodInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addFoodInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.addFoodInvoice.Name = "addFoodInvoice";
            this.addFoodInvoice.Primary = false;
            this.addFoodInvoice.Size = new System.Drawing.Size(124, 36);
            this.addFoodInvoice.TabIndex = 15;
            this.addFoodInvoice.Text = "+ Add Food Item";
            this.addFoodInvoice.UseVisualStyleBackColor = false;
            this.addFoodInvoice.Click += new System.EventHandler(this.addFoodInvoice_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(173, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "Customer Ordered Items";
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
            this.invoiceInfoPanel.Location = new System.Drawing.Point(7, 69);
            this.invoiceInfoPanel.Name = "invoiceInfoPanel";
            this.invoiceInfoPanel.Size = new System.Drawing.Size(583, 102);
            this.invoiceInfoPanel.TabIndex = 15;
            this.invoiceInfoPanel.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Depth = 0;
            this.customerName.Font = new System.Drawing.Font("Roboto", 11F);
            this.customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customerName.Location = new System.Drawing.Point(134, 71);
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
            this.tableNumberInfoLable.Location = new System.Drawing.Point(3, 7);
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
            this.tabelNumber.Location = new System.Drawing.Point(134, 7);
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
            this.tabelLocationInfoLabel.Location = new System.Drawing.Point(3, 38);
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
            this.tableLocations.Location = new System.Drawing.Point(134, 39);
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
            this.customerNameInfoLabel.Location = new System.Drawing.Point(3, 70);
            this.customerNameInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.customerNameInfoLabel.Name = "customerNameInfoLabel";
            this.customerNameInfoLabel.Size = new System.Drawing.Size(131, 19);
            this.customerNameInfoLabel.TabIndex = 7;
            this.customerNameInfoLabel.Text = "Customer Name : ";
            // 
            // invoiceButtonPanle
            // 
            this.invoiceButtonPanle.Controls.Add(this.saveInvoiceButton);
            this.invoiceButtonPanle.Location = new System.Drawing.Point(6, 480);
            this.invoiceButtonPanle.Name = "invoiceButtonPanle";
            this.invoiceButtonPanle.Size = new System.Drawing.Size(586, 52);
            this.invoiceButtonPanle.TabIndex = 13;
            this.invoiceButtonPanle.Visible = false;
            // 
            // saveInvoiceButton
            // 
            this.saveInvoiceButton.AutoSize = true;
            this.saveInvoiceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveInvoiceButton.Depth = 0;
            this.saveInvoiceButton.Location = new System.Drawing.Point(429, 8);
            this.saveInvoiceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveInvoiceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveInvoiceButton.Name = "saveInvoiceButton";
            this.saveInvoiceButton.Primary = true;
            this.saveInvoiceButton.Size = new System.Drawing.Size(147, 36);
            this.saveInvoiceButton.TabIndex = 2;
            this.saveInvoiceButton.Text = "Save Table Invoice";
            this.saveInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // invoiceNumberLable
            // 
            this.invoiceNumberLable.AutoSize = true;
            this.invoiceNumberLable.BackColor = System.Drawing.Color.Transparent;
            this.invoiceNumberLable.Depth = 0;
            this.invoiceNumberLable.Font = new System.Drawing.Font("Roboto", 11F);
            this.invoiceNumberLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.invoiceNumberLable.Location = new System.Drawing.Point(229, 34);
            this.invoiceNumberLable.MouseState = MaterialSkin.MouseState.HOVER;
            this.invoiceNumberLable.Name = "invoiceNumberLable";
            this.invoiceNumberLable.Size = new System.Drawing.Size(17, 19);
            this.invoiceNumberLable.TabIndex = 13;
            this.invoiceNumberLable.Text = "0";
            // 
            // HotelTableInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 536);
            this.Controls.Add(this.invoiceNumberLable);
            this.Controls.Add(this.invoiceButtonPanle);
            this.Controls.Add(this.invoiceItemInfoPanle);
            this.Controls.Add(this.invoiceInfoPanel);
            this.Name = "HotelTableInvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice for table number :   #";
            this.Load += new System.EventHandler(this.HotelTableInvoiceForm_Load);
            this.invoiceItemInfoPanle.ResumeLayout(false);
            this.invoiceItemInfoPanle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceFoodItemDetails)).EndInit();
            this.invoiceInfoPanel.ResumeLayout(false);
            this.invoiceInfoPanel.PerformLayout();
            this.invoiceButtonPanle.ResumeLayout(false);
            this.invoiceButtonPanle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialFlatButton saveInvoiceButton;
        private System.Windows.Forms.Panel invoiceButtonPanle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel invoiceInfoPanel;
        private System.Windows.Forms.Panel invoiceItemInfoPanle;
        private MaterialSkin.Controls.MaterialFlatButton addFoodInvoice;
        private Bunifu.Framework.UI.BunifuCustomDataGrid invoiceFoodItemDetails;
        private MaterialSkin.Controls.MaterialLabel invoiceNumberLable;
        private MaterialSkin.Controls.MaterialLabel totalAmountLable;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
