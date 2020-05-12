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
using MaterialSkin.Controls;

namespace CloudDesktopApp.Component.MainTable
{
    public partial class HotelTableInvoiceForm : MaterialForm
    {
        HotelTableModel tempHotelModel;
        LocalInvoiceModel tempLocalInvoiceModel;
        public HotelTableInvoiceForm()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        public HotelTableInvoiceForm(LocalInvoiceModel localInvoiceModel)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.tempLocalInvoiceModel = localInvoiceModel;
            this.setCustomerDetails();
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
                this.invoiceDateInforPanle.Visible = value;
                this.invoiceInfoPanel.Visible = value;
                this.invoiceItemInfoPanle.Visible = value;
                this.invoiceButtonPanle.Visible = value;
            }
        }
    }
}
