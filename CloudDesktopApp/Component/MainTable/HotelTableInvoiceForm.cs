using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------------
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;
using CloudDesktopApp.Component.HotelTabel.Invoice;
using MaterialSkin.Controls;

namespace CloudDesktopApp.Component.MainTable
{
    public partial class HotelTableInvoiceForm : MaterialForm
    {
        HotelTableModel tempHotelModel;
        LocalInvoiceModel tempLocalInvoiceModel;
        DataView filterInvoiceItemView;

        public HotelTableInvoiceForm()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.gridViewButtonLoad();
        }

        public HotelTableInvoiceForm(LocalInvoiceModel localInvoiceModel)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.tempLocalInvoiceModel = localInvoiceModel;
            this.setCustomerDetails();
            this.gridViewButtonLoad();
        }

        public void setCustomerDetails()
        {
            try
            {
                if (this.tempLocalInvoiceModel != null)
                {
                    this.getHotelModel(this.tempLocalInvoiceModel);
                    tabelNumber.Text = this.tempHotelModel.hotelTableName;
                    tableLocations.Text = this.tempHotelModel.hotelTableLocations;
                    customerName.Text = tempLocalInvoiceModel.customer;
                    invoiceDate.Text = DateTime.Now.ToShortDateString();
                    this.invoiceControleSetVisible(true);
                    this.loadInvoiceFoodItem();
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
            
        }

        private void getHotelModel(LocalInvoiceModel localInvoiceDeatils)
        {
            try
            {
                List<DataRow> tempRow = GlobalClass.hotelTables.AsEnumerable().Where(row=> row["hotelTableId"].Equals(localInvoiceDeatils.hotelTableId.ToString())).ToList();
                if (tempRow.Count >0)
                this.tempHotelModel =  new HotelTableModel(Convert.ToInt32(tempRow[0].ItemArray[0]), tempRow[0].ItemArray[1].ToString(), tempRow[0].ItemArray[2].ToString(), Convert.ToInt32(tempRow[0].ItemArray[3]), Convert.ToDouble(tempRow[0].ItemArray[4]), Convert.ToBoolean(tempRow[0].ItemArray[5]));
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void invoiceControleSetVisible(bool value)
        {
            if (this.tempLocalInvoiceModel != null)
            {
                this.invoiceInfoPanel.Visible = value;
                this.invoiceItemInfoPanle.Visible = value;
                this.invoiceButtonPanle.Visible = value;
            }
        }

        private void addFoodInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                Form formExits = Application.OpenForms["AddFood"];
                if (formExits != null)
                {
                    formExits.Close();
                }
                AddFood tempAddFood = new AddFood(this.tempHotelModel, this.tempLocalInvoiceModel);
                tempAddFood.saveFood += new AddFood.SavingFood(saveFoodAddForm);
                tempAddFood.Show();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void saveFoodAddForm(InvoiceItemModel invoiceItemDetails)
        {
            try
            {
                this.checkInvoiceItemTable();
                GlobalClass.invoiceItemTables.Rows.Add(new object[] { 
                    null, 
                    invoiceItemDetails.invoiceItemName,
                    invoiceItemDetails.invoiceItemPrice,
                    invoiceItemDetails.invoiceItemQty,
                    invoiceItemDetails.invoiceTotalPrice,
                    invoiceItemDetails.invoice.invoiceId
                });
                this.loadInvoiceFoodItem();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
        
        public void checkInvoiceItemTable()
        {
            if(GlobalClass.invoiceItemTables == null){
                List<InvoiceItemModel> tempInvoiceItemModel = new List<InvoiceItemModel>();
                GlobalClass.invoiceItemTables = new ListToDataTableConvetor().ToDataTable<InvoiceItemModel>(tempInvoiceItemModel);
                GlobalClass.invoiceItemTables.Columns["invoiceItemId"].AutoIncrement = true;
                GlobalClass.invoiceItemTables.Columns["invoiceItemId"].AutoIncrementSeed = 1;
                GlobalClass.invoiceItemTables.Columns["invoiceItemId"].AutoIncrementStep = 1;
                GlobalClass.invoiceItemTables.TableName = "InvoiceItem";
                GlobalClass.invoiceDataSet.Tables.Add(GlobalClass.invoiceItemTables);
            }
        }

        private void loadInvoiceFoodItem()
        {
            if (GlobalClass.invoiceItemTables != null)
            {
                this.filterInvoiceItemView = GlobalClass.invoiceItemTables.AsEnumerable().Where(row => row["invoice"].Equals(this.tempLocalInvoiceModel.invoiceId.ToString())).AsDataView();
                this.filterInvoiceItemView.RowFilter = "invoice =" + this.tempLocalInvoiceModel.invoiceId;
                this.loadFilterDataIntoDataGirdView(this.filterInvoiceItemView);
            }
        }

        private void loadFilterDataIntoDataGirdView(DataView filterInvoiceItemView)
        {
                this.invoiceFoodItemDetails.DataSource = filterInvoiceItemView;
                // Visible props
                this.invoiceFoodItemDetails.Columns["invoice"].Visible = false;
                this.invoiceFoodItemDetails.Columns["invoiceItemId"].Visible =false;
                // header text props
                //this.invoiceFoodItemDetails.Columns["invoiceItemId"].HeaderText = "Sr. No.";
                this.invoiceFoodItemDetails.Columns["invoiceItemName"].HeaderText = "Name";
                this.invoiceFoodItemDetails.Columns["invoiceItemPrice"].HeaderText = "Price Unit/-";
                this.invoiceFoodItemDetails.Columns["invoiceItemQty"].HeaderText = "QTY";
                this.invoiceFoodItemDetails.Columns["invoiceTotalPrice"].HeaderText = "Amount";
        }

        public void invoiceFoodItemClear()
        {
            this.invoiceFoodItemDetails.DataSource = null;
            this.invoiceFoodItemDetails.Rows.Clear();
            this.invoiceFoodItemDetails.Refresh();
        }

        private void gridViewButtonLoad()
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "+";
            editButton.Name = "edit";
            editButton.UseColumnTextForButtonValue = true;
            this.invoiceFoodItemDetails.Columns.Add(editButton);
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "X";
            deleteButton.Name = "delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.invoiceFoodItemDetails.Columns.Add(deleteButton);
        }

        private void invoiceFoodItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                this.showFormDetails(senderGrid, e, true, "EDIT");
            }
            else
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    this.showFormDetails(senderGrid, e, false, "DELETE");
                }
            }
        }

        private void showFormDetails(DataGridView senderGrid, DataGridViewCellEventArgs e, Boolean version, string type)
        {
            MessageBox.Show(type);
        }
    }
}
