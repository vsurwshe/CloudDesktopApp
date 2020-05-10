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
        List<CustomerModel> customerList;
        public CustomerManagment()
        {
            InitializeComponent();
        }

        private void CustomerManagment_Load(object sender, EventArgs e)
        {
            this.customerList= this.loadCustomerList();
            if(customerList !=null){
                ViewCustomer customerTable = new ViewCustomer(customerList);
                this.customerTablePanel.Controls.Add(customerTable);
            }else{
                this.noCustomerMessageLable.Visible = true;
            }
        }

        public List<CustomerModel> loadCustomerList()
        {
            List<CustomerModel> customerModel = null;
            try
            {
               customerModel = new CustomerApiServices().getCustomers(false);
            }
            catch (Exception msg) 
            {
                UserMessage.ShowExceptions(msg.Message);
            }
            return customerModel;
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
