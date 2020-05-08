using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------
using CloudDesktopApp.ApiOperations;
namespace CloudDesktopApp.Component.Food
{
    public partial class ViewFood : UserControl
    {
        List<FoodModel> tempFoodTabel;
        public ViewFood(List<FoodModel> foodTabel)
        {
            InitializeComponent();
            this.tempFoodTabel = foodTabel;
        }

        private void ViewFood_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "edit";
            editButton.UseColumnTextForButtonValue = true;
            foodDetails.Columns.Add(editButton);
            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "delete";
            deleteButton.UseColumnTextForButtonValue = true;
            foodDetails.Columns.Add(deleteButton);
            foodDetails.DataSource = this.tempFoodTabel;
            foodDetails.Columns["version"].Visible = false;
        }

        private void foodDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            FoodModel foodDetails = new FoodModel();
            foodDetails.foodId = Convert.ToInt32(row.Cells[2].Value);
            foodDetails.foodName = row.Cells[3].Value.ToString();
            foodDetails.foodPrice = Convert.ToDouble(row.Cells[4].Value);
            foodDetails.foodCategory = row.Cells[5].Value.ToString();
            if (version)
            {
                foodDetails.version = Convert.ToDouble(row.Cells[6].Value);
            }
            Form formExits = Application.OpenForms["FoodForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new FoodForm(foodDetails, type).Show(this);
        }
    }
}
