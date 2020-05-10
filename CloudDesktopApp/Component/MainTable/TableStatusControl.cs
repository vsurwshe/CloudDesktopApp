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
using CloudDesktopApp.Component.HotelTabel;

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
            try
            {
                this.setTables();
                this.loadTableInPanle();
            }
            catch (Exception msg) {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void setTables()
        {
            if (GlobalClass.hotelTables == null)
            {
                GlobalClass.hotelTables = new ListToDataTableConvetor().ToDataTable<HotelTableModel>(tempHotelTableList);
                GlobalClass.hotelTables.TableName = "HotelTables";
                GlobalClass.invoiceDataSet.Tables.Add(GlobalClass.hotelTables);
            }
        }

        public void loadTableInPanle()
        {
            if (GlobalClass.hotelTables.Rows.Count > 0)
            {
                List<DataRow> bookedTable = GlobalClass.hotelTables.Select("booked=true").ToList(); 
                List<DataRow> freeTable = GlobalClass.hotelTables.Select("booked=false").ToList();
                if(bookedTable.Count >0){
                    foreach (var row in bookedTable)
                    {
                        HotelTableModel tempHotelTable = new HotelTableModel(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), Convert.ToInt32(row.ItemArray[3]), Convert.ToDouble(row.ItemArray[0]), Convert.ToBoolean(row.ItemArray[5]));
                        bookedTablesPanel.Controls.Add(new BookedHotelTableControl(tempHotelTable));
                    }
                }
                if(freeTable.Count>0){
                    foreach (var row in freeTable)
                    {
                        HotelTableModel tempHotelTable = new HotelTableModel(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), Convert.ToInt32(row.ItemArray[3]), Convert.ToDouble(row.ItemArray[0]), Convert.ToBoolean(row.ItemArray[5]));
                        freeTablesPanel.Controls.Add(new FreeHotelTableControl(tempHotelTable));
                    }
                }
            }
        }
    }
}
