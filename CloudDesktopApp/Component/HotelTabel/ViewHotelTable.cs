using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class ViewHotelTable : UserControl
    {
        List<HotelTableModel> tempHotelTable;
        public ViewHotelTable(List<HotelTableModel> hotelTableDetails)
        {
            InitializeComponent();
            this.tempHotelTable = hotelTableDetails;
        }

        private void ViewHotelTable_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "edit";
            editButton.UseColumnTextForButtonValue = true;
            hotelTableDetails.Columns.Add(editButton);
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "delete";
            deleteButton.UseColumnTextForButtonValue = true;
            hotelTableDetails.Columns.Add(deleteButton);
            hotelTableDetails.DataSource = this.tempHotelTable;
            hotelTableDetails.Columns["version"].Visible = false;
        }

        private void hotelTableDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                this.showFormDetails(senderGrid, e, true, "EDIT");
            }
            else
            {
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    this.showFormDetails(senderGrid, e, false, "DELETE");
                }
            }
        }

        public void showFormDetails(DataGridView gridView, DataGridViewCellEventArgs e, Boolean version, String type)
        {
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            HotelTableModel hotelTable = new HotelTableModel();
            hotelTable.hotelTableId =Convert.ToInt32(row.Cells[2].Value);
            hotelTable.hotelTableName = row.Cells[3].Value.ToString();
            hotelTable.hotelTableLocations = row.Cells[4].Value.ToString();
            hotelTable.hotelTableSize = Convert.ToInt16(row.Cells[5].Value);
            if (version)
            {
                hotelTable.version = Convert.ToDouble(row.Cells[6].Value);
            }
            Form formExits = Application.OpenForms["HotelTabelForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new HotelTabelForm(hotelTable, type).Show(this);
        }
    }
}
