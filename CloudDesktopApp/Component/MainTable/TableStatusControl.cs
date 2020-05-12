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
using MaterialSkin.Controls;

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
                List<DataRow> bookedTable = this.getListOfRowBasedOnBooked("true");
                List<DataRow> freeTable = this.getListOfRowBasedOnBooked("false");
                this.tablePanleClear();
                if (bookedTable.Count > 0)
                {
                    foreach (var row in bookedTable)
                    {
                        HotelTableModel tempHotelTable = new HotelTableModel(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), Convert.ToInt32(row.ItemArray[3]), Convert.ToDouble(row.ItemArray[0]), Convert.ToBoolean(row.ItemArray[5]));
                        BookedHotelTableControl tempBookedHotelTableControl = new BookedHotelTableControl(tempHotelTable);
                        tempBookedHotelTableControl.loadThePanles += new EventHandler(loadFormChlidUserControl);
                        tempBookedHotelTableControl.viewIconClick += new BookedHotelTableControl.loadInvoiceDelegate(loadViewIconClick);
                        bookedTablesPanel.Controls.Add(tempBookedHotelTableControl);
                    }
                }
                else
                {
                    bookedTablesPanel.Controls.Add(this.loadLableWithMessage(CommonMessage.TABLE_STATUS_NO_BOOKED_TABLES));
                }
                if (freeTable.Count > 0)
                {
                    foreach (var row in freeTable)
                    {
                        HotelTableModel tempHotelTable = new HotelTableModel(Convert.ToInt32(row.ItemArray[0]), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), Convert.ToInt32(row.ItemArray[3]), Convert.ToDouble(row.ItemArray[0]), Convert.ToBoolean(row.ItemArray[5]));
                        FreeHotelTableControl tempFreeHotelTableControl = new FreeHotelTableControl(tempHotelTable);
                        tempFreeHotelTableControl.loadThePanles += new EventHandler(loadFormChlidUserControl);
                        freeTablesPanel.Controls.Add(tempFreeHotelTableControl);
                    }
                }
                else
                {
                    freeTablesPanel.Controls.Add(this.loadLableWithMessage(CommonMessage.TABLE_STATUS_NO_FRESS_TABLES));
                }
            }
        }

        public void loadViewIconClick(LocalInvoiceModel localInvoiceDetails)
        {
            new MainTableManagement().viewInvoiceData(localInvoiceDetails);
        }

        public List<DataRow> getListOfRowBasedOnBooked(String value)
        {
            return GlobalClass.hotelTables.Select("booked="+value).ToList();
        }

        public void tablePanleClear()
        {
            bookedTablesPanel.Controls.Clear();
            freeTablesPanel.Controls.Clear();
        }

        public void loadFormChlidUserControl(object sender, EventArgs e){
            this.loadTableInPanle();
        }

        public MaterialLabel loadLableWithMessage(String message)
        {
            MaterialLabel materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1.AutoSize =true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new System.Drawing.Font("Roboto", 14F);
            materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "messageLable";
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = message;
            return materialLabel1;
        }
    }
}
