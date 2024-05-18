using System;

namespace ClassLibrary
{
    public class clsCustomers
    {

        private Int32 mCustomer_id;
        private String mCustomer_First_Name;
        private String mCustomer_Last_Name;
        private DateTime mCustomer_DOB;
        private String mCustomer_Phone_Nmbr;
        private String mCustomer_Address;
        private Boolean mSave_Payment_Info;


        public bool Save_Payment_Info
        {
            get
            {
                return mSave_Payment_Info;
            }
            set
            {
                mSave_Payment_Info = value;
            }
        }
        public string Customer_First_Name
        {
            get
            {
                return mCustomer_First_Name;
            }
            set
            {
                mCustomer_First_Name = value;
            }
        }
        public string Customer_Last_Name
        {
            get
            {
                return mCustomer_Last_Name;
            }
            set
            {
                mCustomer_Last_Name = value;
            }
        }
        public DateTime Customer_DOB
        {
            get
            {
                return mCustomer_DOB;
            }
            set
            {
                mCustomer_DOB = value;
            }
        }
        public string Customer_Phone_Nmbr
        {
            get
            {
                return mCustomer_Phone_Nmbr;
            }
            set
            {
                mCustomer_Phone_Nmbr = value;
            }
        }

        public string Customer_Address
        {
            get
            {
                return mCustomer_Address;
            }
            set
            {
                mCustomer_Address = value;
            }
        }

        public Int32 Customer_id
        {
            get
            {
                return mCustomer_id;

            }
            set
            {
                mCustomer_id = value;
            }
            

            
        }
        
        //-------Find method-----------


        public bool Find(int Customer_id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection ();
            //add the parameter for the address id to search for
            DB.AddParameter("@Customer_id", Customer_id);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerId");
            //if one record is found(there should either be one or zero
            if (DB.Count == 1)
            {
                mCustomer_id = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_id"]);
                mCustomer_First_Name = Convert.ToString(DB.DataTable.Rows[0]["Customer_First_Name"]);
                mCustomer_Last_Name = Convert.ToString(DB.DataTable.Rows[0]["Customer_Last_Name"]);
                mCustomer_DOB = Convert.ToDateTime(DB.DataTable.Rows[0]["Customer_DOB"]);
                mCustomer_Phone_Nmbr = Convert.ToString(DB.DataTable.Rows[0]["Customer_Phone_Nmbr"]);
                mCustomer_Address = Convert.ToString(DB.DataTable.Rows[0]["Customer_Address"]);
                mSave_Payment_Info = Convert.ToBoolean(DB.DataTable.Rows[0]["Save_Payment_Info"]);
                
                return true;
            }
            //if no record is found
            else
            {
                return false;   
            }
        }

        //--------------Validate method---------------

        public string Valid(string customer_First_Name, string customer_Last_Name, string customer_DOB, string customer_Address, string customer_Phone_Nmbr)
        {
            //create string variable to store the error
            String Error = "";
            if (customer_First_Name.Length == 0)
            {
                //record the error
                Error = Error + "The Customer's first name may not be blank : ";
            }
            return Error;
            
        }





    }
}