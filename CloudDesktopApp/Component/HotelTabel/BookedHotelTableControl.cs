using System;
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

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class BookedHotelTableControl : UserControl
    {
        HotelTableModel tempHotelTableModel;
        public BookedHotelTableControl()
        {
            InitializeComponent();
        }

        public BookedHotelTableControl(HotelTableModel hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTableModel = hotelTableDetails;
            this.tableNumber.Text = hotelTableDetails.hotelTableId.ToString();
        }
    }
}
