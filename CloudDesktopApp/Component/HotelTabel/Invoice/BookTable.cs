using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.HotelTabel.Invoice
{
    public partial class BookTable : MaterialForm
    {
        HotelTableModel tempHotelModel;
        public BookTable()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        public BookTable(HotelTableModel hotelModelDetails)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.tempHotelModel = hotelModelDetails;
        }

        public event EventHandler bookTable;

        private void bookTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookTable != null)
                {
                    this.checkLocalInvoiceModleTable();
                    GlobalClass.localInvoiceTables.Rows.Add(new object[]{null,this.tempHotelModel.hotelTableId.ToString(),customerName.Text});
                    this.bookTable(sender, e);
                    this.Close();
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void checkLocalInvoiceModleTable()
        {
            if (GlobalClass.localInvoiceTables == null)
            {
                List<LocalInvoiceModel> tempLocalInvoiceModel = new List<LocalInvoiceModel>();
                GlobalClass.localInvoiceTables = new ListToDataTableConvetor().ToDataTable<LocalInvoiceModel>(tempLocalInvoiceModel);
                GlobalClass.localInvoiceTables.Columns["invoiceId"].AutoIncrement = true;
                GlobalClass.localInvoiceTables.Columns["invoiceId"].AutoIncrementSeed = 1;
                GlobalClass.localInvoiceTables.Columns["invoiceId"].AutoIncrementStep = 1;
                GlobalClass.localInvoiceTables.TableName = "LocalInvoice";
                GlobalClass.invoiceDataSet.Tables.Add(GlobalClass.localInvoiceTables);
            }
        }
    }
}
