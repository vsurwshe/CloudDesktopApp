using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class FreeHotelTableControl : UserControl
    {
        HotelTableModel tempHotelTableModel;
        public FreeHotelTableControl()
        {
            InitializeComponent();
        }

        public FreeHotelTableControl(HotelTableModel hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTableModel = hotelTableDetails;
            this.tableNumber.Text = hotelTableDetails.hotelTableId.ToString();
        }
    }
}
