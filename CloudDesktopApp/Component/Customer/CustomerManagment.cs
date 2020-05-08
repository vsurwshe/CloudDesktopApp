using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-------------
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.Food
{
    public partial class CustomerManagment : Form
    {
        List<CustomerModel> customerResult;
        public CustomerManagment()
        {
            InitializeComponent();
        }

        private void CustomerManagment_Load(object sender, EventArgs e)
        {
            this.loadCustomerList();
        }

        public void loadCustomerList()
        {
            try
            {
                customerResult = new CustomerApiServices().getCustomers();
                ViewCustomer customerTable = new ViewCustomer(customerResult);
                this.customerTablePanel.Controls.Add(customerTable);
            }
            catch (Exception msg) 
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
        private void customerCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["CustomerForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CustomerForm().Show(this);
        }
    }
}
