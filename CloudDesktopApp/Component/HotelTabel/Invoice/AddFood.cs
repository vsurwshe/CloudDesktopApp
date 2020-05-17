using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;
using MaterialSkin.Controls;

namespace CloudDesktopApp.Component.HotelTabel.Invoice
{
    public partial class AddFood : MaterialForm
    {
        public delegate void SavingFood(InvoiceItemModel foodDetails); 
        public HotelTableModel hotelTableModel;
        public LocalInvoiceModel localInvoiceModel;
        public event SavingFood saveFood;

        public AddFood()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        public AddFood(HotelTableModel hotelTableModel, LocalInvoiceModel localInvoiceModel)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.hotelTableModel = hotelTableModel;
            this.localInvoiceModel = localInvoiceModel;
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            if (saveFood != null)
            {
                InvoiceItemModel tempFoodModel = new InvoiceItemModel(Convert.ToInt32(null), foodName.Text, Convert.ToDouble(foodPrice.Text), Convert.ToInt32(foodQty.Text), (Convert.ToDouble(foodPrice.Text) * Convert.ToDouble(foodQty.Text)),this.localInvoiceModel);
                saveFood(tempFoodModel);
                this.Close();
            }
        }
    }
}
