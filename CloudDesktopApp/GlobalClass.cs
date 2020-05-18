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
        
        // this is global list of objects
        public static List<CustomerModel> customerModelList;
        public static List<FoodModel> foodModelList;
        public static List<HotelTableModel> hotelTableModelList;
        public static List<ProfileModel> profileModelList;
        
        // this is global data set of object
        public static DataSet invoiceDataSet = new DataSet();

        // this is global data table objects
        public static DataTable hotelTables;
        public static DataTable foodTables;
        public static DataTable customerTables;
        public static DataTable localInvoiceTables;
        public static DataTable invoiceItemTables;

        // this is global method declrations
        public static void clearProfileData()
        {
            //customerModelList = null;
            //foodModelList = null;
            //hotelTableModelList = null;
            clearList();
            clearDataTables();
        }

        public static void clearList()
        {
            customerModelList = null;
            foodModelList = null;
            hotelTableModelList = null;
        }

        public static void clearDataTables()
        {
            hotelTables = null;
            foodTables = null;
            customerTables = null;
        }
    }
}
