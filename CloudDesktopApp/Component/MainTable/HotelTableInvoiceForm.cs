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
            if (this.tempLocalInvoiceModel != null)
            {
                tabelNumber.Text = tempLocalInvoiceModel.hotelTableId;
                //tableLocations.Text = tempHotelModel.hotelTableLocations;
                customerName.Text = tempLocalInvoiceModel.customer;
                this.invoiceControleSetVisible(true);
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
