using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//------
using CloudDesktopApp.ApiOperations;
namespace CloudDesktopApp
{
    public static class GlobalClass
    {
        public static User user;
        public static TokenResponse token;
        public static List<CustomerModel> customerModelList;
        public static List<FoodModel> foodModelList;
        public static List<HotelTableModel> hotelTableModelList;
        public static List<ProfileModel> profileModelList;
        

        public static DataSet invoiceDataSet = new DataSet();

        public static DataTable hotelTables;
        public static DataTable foodTables;
        public static DataTable localInvoiceModel;

        public static void clearProfileData()
        {
            customerModelList = null;
            foodModelList = null;
            hotelTableModelList = null;
        }
    }
}
