using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Bunifu.Framework.UI;

namespace CloudDesktopApp.Component.Profile
{
    public partial class ProfileManagement : Form
    {
        BackgroundWorker loadProfileBackgroundWorker = null;
        List<ProfileModel> tempProfiles;
        List<FoodModel> tempFoodModel;
        List<CustomerModel> tempCustomerModel;
        List<HotelTableModel> tempHotelTableModel;


        public ProfileManagement()
        {
            InitializeComponent();
        }
        private void ProfileManagement_Load(object sender, EventArgs e)
        {
            loadProfileBackgroundWorker = new BackgroundWorker();
            this.setProgressBar(true);
            this.setVisiableForm(false);
            progressBar.Style = ProgressBarStyle.Marquee;
            loadProfileBackgroundWorker.DoWork += new DoWorkEventHandler(loadProfile_bgWorker_DoWork);
            loadProfileBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(loadProfile_bgWorker_RunWorkerCompleted);
            loadProfileBackgroundWorker.RunWorkerAsync();
        }

        private void loadProfile_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                this.callCommonApi(true);
                this.loadProfiles();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void callCommonApi(Boolean callProfile)
        {
            try
            {
                if (callProfile)
                {
                    this.tempProfiles = new ProfileApiService().getProfiles(false);
                }
                this.tempCustomerModel = new CustomerApiServices().getCustomers(false);
                this.tempFoodModel = new FoodApiServices().getFoods(false);
                this.tempHotelTableModel = new HotelTableServicesApi().getHotelTables(false);
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public void loadProfiles()
        {
            try
            {
               
                if (tempProfiles != null)
                {
                    profilePanel.Controls.Clear();
                    tempProfiles.ForEach(delegate(ProfileModel profile)
                    {
                        ProfileItems setProfile = new ProfileItems(profile);
                        setProfile.loadProfile += new EventHandler(loadReRunProfile);
                        profilePanel.Controls.Add(setProfile);
                    });
                    this.loadCurrentActiveProfileDeatils();
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void loadReRunProfile(object sender, EventArgs e)
        {
            this.callCommonApi(false);
            this.loadProfiles();
        }

        private void loadProfile_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            this.setVisiableForm(true);
        }
        public void setVisiableForm(Boolean value)
        {
            this.profileFormCard.Visible = value;
            this.profileTextLable.Visible = value;
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

        private void profileCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["CreateProfile"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CreateProfile().Show(this);
        }

        public void loadCurrentActiveProfileDeatils()
        {
            try
            {
                String activeProfileId = Properties.Settings.Default.profileId;
                if (activeProfileId != null)
                {
                    DataRow tempRowData = GlobalClass.profileTables.AsEnumerable().Where(row => row["profileId"].Equals(activeProfileId)).ElementAt(0);
                    if (tempRowData.ItemArray != null)
                    {
                        this.profileNameLable.Text = tempRowData.ItemArray[1].ToString();
                        this.profileTypeLable.Text = tempRowData.ItemArray[2].ToString();
                        this.noOfCustomer.Text = GlobalClass.customerTables != null ? GlobalClass.customerTables.Rows.Count.ToString() : "0";
                        this.noOfFood.Text = GlobalClass.foodTables != null ?  GlobalClass.foodTables.Rows.Count.ToString() :"0";
                        this.noOfHotelTables.Text = GlobalClass.hotelTables != null ? GlobalClass.hotelTables.Rows.Count.ToString() :"0";
                    }
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
    }
}
