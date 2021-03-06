﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;
using CloudDesktopApp.Component.MainTable;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class BookedHotelTableControl : UserControl
    {
        public delegate void loadInvoiceDelegate(LocalInvoiceModel localInvoice);
        HotelTableModel tempHotelTableModel;
        LocalInvoiceModel tempLocalInvoiceModel;
        public event EventHandler loadThePanles;
        public event loadInvoiceDelegate viewIconClick;

        public BookedHotelTableControl()
        {
            InitializeComponent();
        }

        public BookedHotelTableControl(HotelTableModel hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTableModel = hotelTableDetails;
            this.tableNumber.Text = hotelTableDetails.hotelTableName;
            this.tempLocalInvoiceModel = this.getLocalInvoiceModel();
        }

        private void unbookedTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.localInvoiceTables.AsEnumerable().Where(row => (row["hotelTableId"].Equals(tempHotelTableModel.hotelTableId.ToString()) && row["invoiceId"].Equals(tempLocalInvoiceModel.invoiceId))).ToList().ForEach(rec=> GlobalClass.localInvoiceTables.Rows.Remove(rec));
                GlobalClass.hotelTables.AsEnumerable().Where(row => row["hotelTableId"].Equals(tempHotelTableModel.hotelTableId.ToString())).ToList().ForEach(rec => rec.SetField("booked", "false"));
                if (loadThePanles != null)
                    loadThePanles(this, EventArgs.Empty);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void viewInvoiceButton_Click(object sender, EventArgs e)
        {
            if (viewIconClick != null)
                viewIconClick(this.tempLocalInvoiceModel);
        }

        public LocalInvoiceModel getLocalInvoiceModel()
        {
            LocalInvoiceModel tempLocalInvoiceResult = null;
            if (GlobalClass.localInvoiceTables != null)
            {
               List<DataRow> tempDataRow = GlobalClass.localInvoiceTables.AsEnumerable().Where(row => row["hotelTableId"].Equals(this.tempHotelTableModel.hotelTableId.ToString())).ToList();
               tempLocalInvoiceResult = new LocalInvoiceModel(Convert.ToInt32(tempDataRow[0].ItemArray[0]), tempDataRow[0].ItemArray[1].ToString(), tempDataRow[0].ItemArray[2].ToString());
            }
            return tempLocalInvoiceResult;
        }
        public void viewInvoice()
        {
            if (viewIconClick != null)
                viewIconClick(this.tempLocalInvoiceModel);
        }

        public void materialLabel1_Click(object sender, EventArgs e)
        {
            this.viewInvoice();
        }

        public void tableNumber_Click(object sender, EventArgs e)
        {
            this.viewInvoice();
        }
    }
}
