using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public clsCustomers()
        {
        }

        public bool Save_Payment_Info { get; set; }
        public string Customer_First_Name { get; set; }
        public string Customer_Last_Name { get; set; }
        public DateTime Customer_DOB { get; set; }
        public string Customer_Phone_Nmbr { get; set; }
        public string Customer_Address { get; set; }
        public object Customer_id { get; set; }

        public bool Find(int customer_id)
        {
            //always return true
            return true;
        }
    }
}