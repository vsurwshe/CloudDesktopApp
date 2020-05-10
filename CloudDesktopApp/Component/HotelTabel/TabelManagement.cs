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
    public partial class TabelManagement : Form
    {
        List<HotelTableModel> hotelTableList;
        public TabelManagement()
        {
            InitializeComponent();
        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            this.hotelTableList = this.loadHotelTable();
            if (this.hotelTableList != null)
            {
                ViewHotelTable hotelTable = new ViewHotelTable(hotelTableList);
                this.hotelTablePanel.Controls.Add(hotelTable);
            }
            else {
                this.noHotelTableMessageLable.Visible = true;
            }
            
        }

        public List<HotelTableModel> loadHotelTable()
        {
            List<HotelTableModel> listOfHotelTable = null;
            try
            {
                listOfHotelTable = new HotelTableServicesApi().getHotelTables(false);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
            return listOfHotelTable;
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
