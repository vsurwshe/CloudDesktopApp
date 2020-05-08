using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;

namespace CloudDesktopApp.Component.HotelTabel
{
    public partial class HotelTabelForm : MaterialForm
    {
        BackgroundWorker createHotelTableWorker;
        HotelTableModel tempHotelTableModel;
        String formActions = null;
        public HotelTabelForm()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        public HotelTabelForm(HotelTableModel hotelModelDetails,String operations)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.formActions = operations;
            this.loadFormValues(hotelModelDetails, operations);
        }

        public void loadFormValues(HotelTableModel hotelTableDetails, String opertions)
        {
            this.tempHotelTableModel = hotelTableDetails;
            this.saveHotelTableButton.Text = opertions.Equals("EDIT") ? "Edit Hotel Table Details" : "Delete Hotel Table Details";
            hotelTabelName.Text = hotelTableDetails.hotelTableName;
            hotelTabelSize.Text = hotelTableDetails.hotelTableSize.ToString();
            hotelTableLocations.Text = hotelTableDetails.hotelTableLocations;
        }

        private void saveHotelTableButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(hotelTabelSize.Text) || String.IsNullOrEmpty(hotelTableLocations.Text) || String.IsNullOrEmpty(hotelTabelName.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.HOTEL_TABLE_INVALID_DATA_MESSAGE);
            }
            else
            {
                createHotelTableWorker = new BackgroundWorker();
                this.setProgressBar(true);
                saveHotelTableButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                if (formActions != null && formActions.Equals("EDIT"))
                {
                    createHotelTableWorker.DoWork += new DoWorkEventHandler(this.editHotelTable_bgWorker_DoWork);
                }
                else
                {
                    if (formActions != null && formActions.Equals("DELETE"))
                    {
                        createHotelTableWorker.DoWork += new DoWorkEventHandler(this.deleteHotelTable_bgWorker_DoWork);
                    }
                    else
                    {
                        createHotelTableWorker.DoWork += new DoWorkEventHandler(this.createHotelTable_bgWorker_DoWork);
                    }
                }
                createHotelTableWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(saveHotelTable_bgWorker_RunWorkerCompleted);
                createHotelTableWorker.RunWorkerAsync();
            }
        }

        private void createHotelTable_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String hotelTableBodyData = JsonConvert.SerializeObject(new { 
                hotelTableLocations = hotelTableLocations.Text,
                hotelTableName = hotelTabelName.Text,
                hotelTableSize = Convert.ToInt16(hotelTabelSize.Text),
                });
                HotelTableModel result = new HotelTableServicesApi().saveHotelTable(hotelTableBodyData);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.HOTEL_TABLE_SAVED_SUCCESS_MESSAGE);
                    this.InvokeCustomer(sender, e);
                }
                else
                {
                    throw new Exception(CommonMessage.HOTEL_TABLE_SAVED_UNSUCCESS_MESSAGE);
                }
            }
            catch (Exception msg) {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void deleteHotelTable_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String result = new HotelTableServicesApi().deleteHotelTable(tempHotelTableModel);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.HOTEL_TABLE_DELETE_SUCCESS_MESSAGE);
                    this.InvokeCustomer(sender, e);
                }
                else
                {
                    throw new Exception(CommonMessage.HOTEL_TABLE_DELETE_UNSUCCESS_MESSAGE);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void editHotelTable_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                tempHotelTableModel.hotelTableLocations = hotelTableLocations.Text;
                tempHotelTableModel.hotelTableName = hotelTabelName.Text;
                tempHotelTableModel.hotelTableSize = Convert.ToInt16(hotelTabelSize.Text);
                String hotelTableBodyData = JsonConvert.SerializeObject(tempHotelTableModel);
                HotelTableModel result = new HotelTableServicesApi().updateHotelTable(tempHotelTableModel.hotelTableId, hotelTableBodyData);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.HOTEL_TABLE_UPDATE_SUCCESS_MESSAGE);
                    this.InvokeCustomer(sender, e);
                }
                else
                {
                    throw new Exception(CommonMessage.HOTEL_TABLE_UPDATE_UNSUCCESS_MESSAGE);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void saveHotelTable_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            saveHotelTableButton.Enabled = true;
        }

        // This method seting values of progress bar
        private void setProgressBar(Boolean progressBarvalue)
        {
            if (progressBarvalue)
            {// This lines setting progress bar values 
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 10;
                progressBar.Step = 10;
            }
            progressBar.Visible = progressBarvalue;
        }
        // This method calling the main dashborad load profile method
        public void InvokeCustomer(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                UserDashborad myParent = (UserDashborad)this.Owner;
                myParent.Tabel_Click(sender, e);
                this.Dispose();
            }));
        }


    }
}
