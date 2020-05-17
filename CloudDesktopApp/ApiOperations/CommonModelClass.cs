using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudDesktopApp.ApiOperations
{
    class CommonModelClass
    {
    }

    // This User model class
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public Double userBalance { get; set; }
        public Boolean enabled { get; set; }
    }

    // This is token respoense model class
    public class TokenResponse
    {
        public string userToken { get; set; }
        public string userRefreshToken { get; set; }
        public User userDetails { get; set; }

    }

    // This is profile Model Class
    public class ProfileModel
    {
        public Int32 profileId { get; set; }
        public string profileName { get; set; }
        public string type { get; set; }
        public string[] features { get; set; }
        public int version { get; set; }
    }

    // This is Profile Types model class
    public class ProfileTypes
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string features { get; set; }
        public Double cost { get; set; }
        public int version { get; set; }
    }

    // This is Customer model class
    public class CustomerModel
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerMobileNo { get; set; }
        public string customerEmail { get; set; }
        public string customerAddress { get; set; }
        public double version { get; set; }
    }

    // This is Food model class
    public class FoodModel
    {
        public int foodId { get; set; }
        public string foodName { get; set; }
        public double foodPrice { get; set; }
        public string foodCategory { get; set; }
        public double version { get; set; }
    }

    // This is HotelTable model class
    public class HotelTableModel
    {
        public int hotelTableId { get; set; }
        public string hotelTableName { get; set; }
        public string hotelTableLocations { get; set; }
        public int hotelTableSize { get; set; }
        public double version { get; set; }
        public Boolean booked { get; set; }

        public HotelTableModel() { }

        public HotelTableModel(int hotelTableId, string hotelTableName, string hotelTableLocations, int hotelTableSize, double version, Boolean booked)
        {
            this.hotelTableId = hotelTableId;
            this.hotelTableName = hotelTableName;
            this.hotelTableLocations = hotelTableLocations;
            this.hotelTableSize = hotelTableSize;
            this.version = version;
            this.booked = booked;
        }
    }

    // This is invoice model class
    public class LocalInvoiceModel
    {
        public int invoiceId { get; set; }
        public String hotelTableId { get; set; }
        public String customer { get; set; }
        public LocalInvoiceModel(){}
        public LocalInvoiceModel(int id, String hotel, String customerName)
        {
            this.invoiceId = id;
            this.hotelTableId = hotel;
            customer = customerName;
        }
    }

    public class InvoiceItemModel 
    {
        public int invoiceItemId { get; set; }
        public String invoiceItemName { get; set; }
        public Double invoiceItemPrice { get; set; }
        public int invoiceItemQty { get; set; }
        public Double invoiceTotalPrice { get; set; }
        public LocalInvoiceModel invoice {get; set;}

        public InvoiceItemModel() { }
        
        public InvoiceItemModel(int id , String itemName, Double itemPrice, int itemQty, Double itemTotal, LocalInvoiceModel localInvoice)
        {
            this.invoiceItemId = id;
            this.invoiceItemName = itemName;
            this.invoiceItemPrice = itemPrice;
            this.invoiceItemQty = itemQty;
            this.invoiceTotalPrice = itemTotal;
            this.invoice = localInvoice;
        }
    }
}
