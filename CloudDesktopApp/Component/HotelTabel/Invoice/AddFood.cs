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
        public delegate void SavingFood(InvoiceItemModel foodDetails); 
        public HotelTableModel hotelTableModel;
        public LocalInvoiceModel localInvoiceModel;
        public event SavingFood saveFood;

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
            if (saveFood != null)
            {
                string foodName = foodComboBox.SelectedItem.ToString();
                InvoiceItemModel tempFoodModel = new InvoiceItemModel(Convert.ToInt32(null), foodName, Convert.ToDouble(foodPrice.Text), Convert.ToInt32(foodQty.Text), (Convert.ToDouble(foodPrice.Text) * Convert.ToDouble(foodQty.Text)),this.localInvoiceModel);
                saveFood(tempFoodModel);
                this.Close();
            }
        }

        private void foodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foodComboBox.SelectedValue != null && foodComboBox.Focused)
            {
                DataRow foodPrice = GlobalClass.foodTables.Select("foodId="+foodComboBox.SelectedValue.ToString()).ElementAt(0);
                this.foodPrice.Text = foodPrice.ItemArray[2].ToString();
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
            this.Invoke(new MethodInvoker(delegate()
            {
                new UserDashborad().Food_Click(sender, e);
                this.Dispose();
            }));
        }
    }
}
