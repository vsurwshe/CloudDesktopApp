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
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.Food
{
    public partial class FoodManagement : Form
    {
        List<FoodModel> foodList;
        public FoodManagement()
        {
            InitializeComponent();
        }

        private void FoodManagement_Load(object sender, EventArgs e)
        {
            this.foodList=this.loadFoods();
            if (this.foodList != null)
            {
                ViewFood foodTable = new ViewFood(foodList);
                this.foodPanel.Controls.Add(foodTable);
            }
            else
            {
                this.noFoodMessageLable.Visible = true;
            }
            
        }

        public List<FoodModel> loadFoods()
        {
            List<FoodModel> tempFoodModel = null;
            try {
                    tempFoodModel = new FoodApiServices().getFoods(false);
                    GlobalClass.foodTables = new ListToDataTableConvetor().ToDataTable<FoodModel>(tempFoodModel);
            }catch(Exception msg){
                UserMessage.ShowExceptions(msg.Message);
            }
            return tempFoodModel;
        }

        private void foodCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["FoodForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new FoodForm().Show(this);
        }
    }
}
