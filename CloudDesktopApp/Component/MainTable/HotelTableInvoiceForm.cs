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
        //-------- temp declare the model class object
        HotelTableModel tempHotelModel;
        LocalInvoiceModel tempLocalInvoiceModel;

        //-------- temp declare the DataView 
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

        private void HotelTableInvoiceForm_Load(object sender, EventArgs e)
        {
            this.showDetailsLable();
        }

        // this function used for the seting customer details in customer panel
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

        // this function used for the show the lable values  
        public void showDetailsLable()
        {
            if (this.tempLocalInvoiceModel != null)
            {
                this.invoiceNumberLable.Text = this.tempLocalInvoiceModel.invoiceId.ToString();
                this.totalAmountLable.Text= this.getTotalInvocieAmount().ToString();
            }
        }

        // this function used for get the total amount of invoice items 
        public Double getTotalInvocieAmount()
        {
            Double total = 0.0;
            if (this.tempLocalInvoiceModel != null && GlobalClass.invoiceItemTables!=null)
            {
                total = Convert.ToDouble(GlobalClass.invoiceItemTables.AsEnumerable().Where(row => row["invoice"].Equals(this.tempLocalInvoiceModel.invoiceId.ToString())).Sum(row => Convert.ToDecimal(row["invoiceTotalPrice"])));
            }
            return total;
        }

        // this function used for the return HotelModel
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

        // this function is used for the setting visiable value of control 
        private void invoiceControleSetVisible(bool value)
        {
            if (this.tempLocalInvoiceModel != null)
            {
                this.invoiceInfoPanel.Visible = value;
                this.invoiceItemInfoPanle.Visible = value;
                this.invoiceButtonPanle.Visible = value;
            }
        }

        // this functions used for the showing add food click
        private void addFoodInvoice_Click(object sender, EventArgs e)
        {
                Form formExits = Application.OpenForms["AddFood"];
                if (formExits != null)
                {
                    formExits.Close();
                }
                AddFood tempAddFood = new AddFood(this.tempHotelModel, this.tempLocalInvoiceModel);
                tempAddFood.saveFood += new AddFood.SavingFood(saveFoodAddForm);
                tempAddFood.loadFoodItems += new EventHandler(loadAgainFoodItemsTables);
                tempAddFood.Show();
        }

        // this function used for the load the food item details 
        private void loadAgainFoodItemsTables(object sender, EventArgs e)
        {
            this.loadInvoiceFoodItem();
            this.showDetailsLable();
        }

        // this is deleget the function when add food form is sumbit that time this function is called
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
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
        
        // this function is used for the invoice item table is there or not
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

        // this function used for the loading realted invoice id food 
        private void loadInvoiceFoodItem()
        {
            if (GlobalClass.invoiceItemTables != null)
            {
                this.filterInvoiceItemView = GlobalClass.invoiceItemTables.AsEnumerable().Where(row => row["invoice"].Equals(this.tempLocalInvoiceModel.invoiceId.ToString())).AsDataView();
                this.filterInvoiceItemView.RowFilter = "invoice =" + this.tempLocalInvoiceModel.invoiceId;
                this.loadFilterDataIntoDataGirdView(this.filterInvoiceItemView);
            }
        }

        // this is setting properties of DataGirdView
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

        // this function used for the clear items
        public void invoiceFoodItemClear()
        {
            this.invoiceFoodItemDetails.DataSource = null;
            this.invoiceFoodItemDetails.Rows.Clear();
            this.invoiceFoodItemDetails.Refresh();
        }

        // this function is used for the setting button in DatagridView
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

        // this function is used for the datagirdview button actions
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
