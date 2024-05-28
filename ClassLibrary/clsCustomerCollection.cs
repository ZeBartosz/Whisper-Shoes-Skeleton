using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for list
        List<clsCustomers> mCustomerList = new List<clsCustomers>();

        public clsCustomerCollection()
        {
            //variable for index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index< RecordCount)
            {
                //create a blank address
                clsCustomers ACustomer = new clsCustomers();
                //read in fields for the current record
                ACustomer.Save_Payment_Info = Convert.ToBoolean(DB.DataTable.Rows[Index]["Save_Payment_Info"]);
                ACustomer.Customer_id = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_id"]);
                ACustomer.Customer_First_Name = Convert.ToString(DB.DataTable.Rows[Index]["Customer_First_Name"]);
                ACustomer.Customer_Last_Name = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Last_Name"]);
                ACustomer.Customer_DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["Customer_DOB"]);
                ACustomer.Customer_Address = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Address"]);
                ACustomer.Customer_Phone_Nmbr = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Phone_Nmbr"]);

            }

        }

        public List<clsCustomers> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //to do later
            }
        }
        public clsCustomers ThisCustomer { get; set; }
    }
}