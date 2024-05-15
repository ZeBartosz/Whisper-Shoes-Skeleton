using System;

namespace ClassLibrary
{
    public class clsCustomers
    {

        private Int32 mCustomer_id;
        private String mCustomer_First_Name;
        private String mCustomer_Last_Name;
        private DateTime mCustomer_DOB;


        public bool Save_Payment_Info { get; set; }
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
        public string Customer_Phone_Nmbr { get; set; }
        public string Customer_Address { get; set; }

        //practical 9 page 8
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
        

        public bool Find(int customer_id)
        {
            //set the private data members to the test data value
            mCustomer_id = 1;
            mCustomer_First_Name = "Ethan";
            mCustomer_Last_Name = "Brogan";
            mCustomer_DOB = Convert.ToDateTime ("22/08/2013");
            //always return true
            return true;
        }

    }
}