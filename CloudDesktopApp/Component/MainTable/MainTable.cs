using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------------
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;
using CloudDesktopApp.Component.HotelTabel;
using CloudDesktopApp.Component.Food;

namespace CloudDesktopApp.Component.MainTable
{
    public partial class MainTableManagement : Form
    {
        List<HotelTableModel> tempHotelTableList;
        List<FoodModel> tempFoodsList;
        public MainTableManagement()
        {
            InitializeComponent();
        }

        private void MainTableManagement_Load(object sender, EventArgs e)
        {
            this.loadProfileRealtedData();
            hotelTablesPanle.Controls.Add(new TableStatusControl());
            invoicePanel.Controls.Add(new HotelTableInvoiceControl());
        }

        private void loadProfileRealtedData()
        {
                this.tempHotelTableList = new TabelManagement().loadHotelTable();
                this.tempFoodsList = new FoodManagement().loadFoods();
        }
    }
}
