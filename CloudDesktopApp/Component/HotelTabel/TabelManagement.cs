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


namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class Tabel : Form
    {
        List<HotelTableModel> hotelTableList;
        public Tabel()
        {
            InitializeComponent();
        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            this.loadHotelTable();
        }

        public void loadHotelTable()
        {
            try
            {
                hotelTableList = new HotelTableServicesApi().getHotelTables();
                ViewHotelTable hotelTable = new ViewHotelTable(hotelTableList);
                this.hotelTablePanel.Controls.Add(hotelTable);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
        private void hotelTableCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["HotelTabelForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new HotelTabelForm().Show(this);
        }
    }
}
