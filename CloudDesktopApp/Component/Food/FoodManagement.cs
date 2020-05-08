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
            this.loadFoods();    
        }

        public void  loadFoods()
        {
            try {
                foodList = new FoodApiServices().getFoods();
                ViewFood foodTable = new ViewFood(foodList);
                this.foodPanel.Controls.Add(foodTable);
            }catch(Exception msg){
                UserMessage.ShowExceptions(msg.Message);
            }
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
