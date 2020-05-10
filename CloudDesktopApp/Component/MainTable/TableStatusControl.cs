using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------------------
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;

namespace CloudDesktopApp.Component.MainTable
{
    public partial class TableStatusControl : UserControl
    {
        List<HotelTableModel> tempHotelTableList;
        public TableStatusControl()
        {
            InitializeComponent();
        }

        public TableStatusControl(List<HotelTableModel> hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTableList = hotelTableDetails;
        }

        private void TableStatusControl_Load(object sender, EventArgs e)
        {
            if (GlobalClass.hotelTables == null)
            {
                GlobalClass.hotelTables = new ListToDataTableConvetor().ToDataTable<HotelTableModel>(tempHotelTableList);
            }
        }
    }
}
