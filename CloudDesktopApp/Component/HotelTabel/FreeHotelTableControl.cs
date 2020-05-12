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
using CloudDesktopApp.Component.MainTable;
using CloudDesktopApp.Component.HotelTabel.Invoice;
using CloudDesktopApp.Helper;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class FreeHotelTableControl : UserControl
    {
        HotelTableModel tempHotelTableModel;
        public event EventHandler loadThePanles;

        public FreeHotelTableControl()
        {
            InitializeComponent();
        }

        public FreeHotelTableControl(HotelTableModel hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTableModel = hotelTableDetails;
            this.tableNumber.Text = hotelTableDetails.hotelTableName;
        }

        public FreeHotelTableControl(HotelTableModel hotelTableDetails, FreeHotelTableControl classObject)
        {
            InitializeComponent();
            this.tempHotelTableModel = hotelTableDetails;
            this.tableNumber.Text = hotelTableDetails.hotelTableName;
            this.Parent = classObject;
        }

        public void bookTableButton_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["BookTable"];
            if (formExits != null)
            {
                formExits.Close();
            }
            BookTable tempBookTable = new BookTable(this.tempHotelTableModel);
            tempBookTable.bookTable += new EventHandler(bookTheConfiromTable);
            tempBookTable.Show(this);
        }

        public void bookTheConfiromTable(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.hotelTables.AsEnumerable().Where(row => row["hotelTableId"].Equals(tempHotelTableModel.hotelTableId.ToString())).ToList().ForEach(rec => rec.SetField("booked", "true"));
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
