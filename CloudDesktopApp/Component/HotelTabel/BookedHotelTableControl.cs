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
using CloudDesktopApp.Helper;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class BookedHotelTableControl : UserControl
    {
        HotelTableModel tempHotelTableModel;
        public event EventHandler loadThePanles;
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

        private void unbookedTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.hotelTables.AsEnumerable().Where(row => row["hotelTableId"].Equals(tempHotelTableModel.hotelTableId.ToString())).ToList().ForEach(rec => rec.SetField("booked", "false"));
                if (loadThePanles != null)
                    loadThePanles(this, EventArgs.Empty);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
    }
}
