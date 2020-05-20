using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;

namespace CloudDesktopApp.Component.Food
{
    public partial class FoodForm : MaterialForm
    {
        BackgroundWorker createFoodWorker;
        FoodModel tempFoodModel;
        String formActions = null;
        public FoodForm()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        public FoodForm(FoodModel foodDetails, String opertions)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.formActions = opertions;
            this.loadFormValues(foodDetails, opertions);
        }

        public void loadFormValues(FoodModel foodDetails, String opertions)
        {
            this.tempFoodModel = foodDetails;
            this.saveFoodButton.Text = opertions.Equals("EDIT") ? "Edit Food Details" : "Delete Food Details";
            foodName.Text = foodDetails.foodName;
            foodCategory.Text=foodDetails.foodCategory;
            foodPrice.Text=foodDetails.foodPrice.ToString();
        }

        private void saveFoodButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(foodName.Text) || String.IsNullOrEmpty(foodCategory.Text) || String.IsNullOrEmpty(foodPrice.Text) )
            {
                UserMessage.showWarningMessage(CommonMessage.FOOD_INVALID_DATA_MESSAGE);
            }
            else
            {
                createFoodWorker = new BackgroundWorker();
                this.setProgressBar(true);
                saveFoodButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                if (formActions != null && formActions.Equals("EDIT"))
                {
                    createFoodWorker.DoWork += new DoWorkEventHandler(this.editFood_bgWorker_DoWork);
                }
                else
                {
                    if (formActions != null && formActions.Equals("DELETE"))
                    {
                        createFoodWorker.DoWork += new DoWorkEventHandler(this.deleteFood_bgWorker_DoWork);
                    }
                    else
                    {
                        createFoodWorker.DoWork += new DoWorkEventHandler(this.createFood_bgWorker_DoWork);
                    }
                }
                createFoodWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(saveFood_bgWorker_RunWorkerCompleted);
                createFoodWorker.RunWorkerAsync();
              }
            }

            private void createFood_bgWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                try{

                    String foodBodyData = JsonConvert.SerializeObject(new { 
                    foodName=foodName.Text,
                    foodPrice=Convert.ToDouble(foodPrice.Text),
                    foodCategory=foodCategory.Text
                    });
                    FoodModel result = new FoodApiServices().saveFood(foodBodyData);
                    if (result != null)
                    {
                        UserMessage.showSuccessMessage(CommonMessage.FOOD_SAVED_SUCCESS_MESSAGE);
                        this.InvokeCustomer(sender, e);
                    }
                    else
                    {
                        throw new Exception(CommonMessage.FOOD_SAVED_UNSUCCESS_MESSAGE);
                    }
                }catch(Exception msg){
                    UserMessage.ShowExceptions(msg.Message);
                }
            }

            private void deleteFood_bgWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                try
                {
                    String result = new FoodApiServices().deleteFood(tempFoodModel);
                    if (result != null)
                    {
                        UserMessage.showSuccessMessage(CommonMessage.FOOD_DELETE_SUCCESS_MESSAGE);
                        this.InvokeCustomer(sender, e);
                    }
                    else
                    {
                        throw new Exception(CommonMessage.FOOD_DELETE_UNSUCCESS_MESSAGE);
                    }
                }
                catch (Exception msg)
                {
                    UserMessage.ShowExceptions(msg.Message);
                }
            }

            private void editFood_bgWorker_DoWork(object sender, DoWorkEventArgs e)
            {
                try
                {
                    tempFoodModel.foodName = foodName.Text;
                    tempFoodModel.foodPrice = Convert.ToDouble(foodPrice.Text);
                    tempFoodModel.foodCategory = foodCategory.Text;
                    String foodBodyData = JsonConvert.SerializeObject(tempFoodModel);
                    FoodModel result = new FoodApiServices().updateFood(tempFoodModel.foodId, foodBodyData);
                    if (result != null)
                    {
                        UserMessage.showSuccessMessage(CommonMessage.FOOD_UPDATE_SUCCESS_MESSAGE);
                        this.InvokeCustomer(sender, e);
                    }
                    else
                    {
                        throw new Exception(CommonMessage.FOOD_UPDATE_UNSUCCESS_MESSAGE);
                    }
                }
                catch (Exception msg)
                {
                    UserMessage.ShowExceptions(msg.Message);
                }
            }

            private void saveFood_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
            {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            saveFoodButton.Enabled = true;
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
                    if (this.Owner.Equals("UserDashborad"))
                    {
                        UserDashborad myParent = (UserDashborad)this.Owner;
                        myParent.Food_Click(sender, e);
                    }
                    this.Dispose();
                }));
            }
        }
}
    
