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
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;
using CloudDesktopApp.Component.Food;
using MaterialSkin.Controls;

namespace CloudDesktopApp.Component.HotelTabel.Invoice
{
    public partial class AddFood : MaterialForm
    {
        //--------- Delegate functions declartions
        public delegate void SavingFood(InvoiceItemModel foodDetails);

        //---------- Common variable declartions
        public BackgroundWorker addFoodBackgroundWorker;
        public String selectedFood = null;

        //---------- Data tabel models
        public HotelTableModel hotelTableModel;
        public LocalInvoiceModel localInvoiceModel;
        
        //---------- Event handler
        public event SavingFood saveFood;
        public event EventHandler loadFoodItems;


        public AddFood()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.loadFoodComboBox();
        }

        public AddFood(HotelTableModel hotelTableModel, LocalInvoiceModel localInvoiceModel)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.hotelTableModel = hotelTableModel;
            this.localInvoiceModel = localInvoiceModel;
            this.loadFoodComboBox();
        }

        public void loadFoodComboBox()
        {
            if (GlobalClass.foodModelList != null)
            {
                this.setValuesFormComboBox();
            }
            else
            {
                new FoodManagement().loadFoods();
                this.setValuesFormComboBox();
            }
        }

        public void setValuesFormComboBox()
        {
            foodComboBox.DataSource = GlobalClass.foodTables;
            foodComboBox.DisplayMember = "foodName";
            foodComboBox.ValueMember = "foodId";
        }

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(foodPrice.Text) || String.IsNullOrEmpty(foodQty.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.ADD_FOOD_INVALID_DATA_MESSAGE);
            }
            else
            {
                addFoodBackgroundWorker = new BackgroundWorker();
                this.setProgressBar(true);
                addFoodButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                addFoodBackgroundWorker.DoWork += new DoWorkEventHandler(this.addFood_bgWorker_DoWork);
                addFoodBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.addFood_bgWorker_RunWorkerCompleted);
                addFoodBackgroundWorker.RunWorkerAsync();
            }
        }

        // this function used for while showing prograss bar do the work
        private void addFood_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (this.selectedFood != "" && this.selectedFood != null && saveFood != null)
                {
                    string foodNameString = this.selectedFood;
                    InvoiceItemModel tempFoodModel = new InvoiceItemModel(Convert.ToInt32(null), foodNameString, Convert.ToDouble(foodPrice.Text), Convert.ToInt32(foodQty.Text), (Convert.ToDouble(foodPrice.Text) * Convert.ToDouble(foodQty.Text)), this.localInvoiceModel);
                    saveFood(tempFoodModel);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        // this function used for the after complete progress bar show completed what task to do?
        private void addFood_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            addFoodButton.Enabled = true;
            if (loadFoodItems != null)
            {
                this.loadFoodItems(sender, e);
            }
            this.Close();
        }
        
        // when food item changed in the combo box that time this functions is called
        private void foodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foodComboBox.SelectedValue != null && foodComboBox.Focused)
            {
                this.selectedFood = "";
                List<DataRow> foodItem = GlobalClass.foodTables.AsEnumerable().Where(row => row["foodId"].Equals(foodComboBox.SelectedValue.ToString())).ToList();
                if (foodItem.Count > 0)
                {
                    this.selectedFood = foodItem[0].ItemArray[1].ToString();
                    this.foodPrice.Text = foodItem[0].ItemArray[2].ToString();
                }
            }
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            try
            {
                this.createFoodLinkLable.Visible = this.checkCreateFoodLinkLable();
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private bool checkCreateFoodLinkLable()
        {
            if (GlobalClass.foodTables != null)
            {
                return false;
            }
            return true;
        }

        private void createFoodLinkLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.InvokeFood(sender, e);
        }

        public void InvokeFood(object sender, EventArgs e)
        {
                Form formExits = Application.OpenForms["FoodForm"];
                if (formExits != null)
                {
                    formExits.Close();
                }
                new FoodForm().Show(this);
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
    }
}
