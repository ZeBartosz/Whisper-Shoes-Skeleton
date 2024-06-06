using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }


        private Int32 mCustomerId;
        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }
        private Int32 mItemId;
        public Int32 ItemId
        {
            get
            {
                return mItemId;
            }
            set
            {
                mItemId = value;
            }
        }
        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private float mTotalAmount;

        public float TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }
        private string mShippingAddress;

        public string ShippingAddress
        {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }
        }
        private Boolean mOrderCompleted;

        public Boolean OrderCompleted
        {
            get
            {
                return mOrderCompleted;
            }
            set
            {
                mOrderCompleted = value;
            }
        }

        public bool Active { get; set; }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = (float)Convert.ToDecimal(DB.DataTable.Rows[0]["TotalAmount"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);
                return true;
            }
            else
            {
                return false;
            }

        }

        public string Valid(string customerId, string itemId, string orderDate, string totalAmount, string shippingAddress)
        {

            string Error = "";
            DateTime DateTemp;

            if (customerId.Length == 0)
            {
                Error = Error + "The Customer Id may not be blank : ";
            }

            if (customerId.Length > 50)
            {
                Error = Error + "The Customer Id has to contain less than 50 characters : ";
            }
            if (itemId.Length == 0)
            {
                Error = Error + "The Item Id may not be blank : ";
            }
            if (itemId.Length > 500)
            {
                Error = Error + "The Item Id must be less than 500 characters";
            }
            if (shippingAddress.Length == 0)
            {
                Error = Error + "The Shipping Address may not be blank : ";
            }
            if (shippingAddress.Length > 60)
            {
                Error = Error + "The Shipping Address must be less than 60 characters";
            }

            

            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be on the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }

        
    }
}