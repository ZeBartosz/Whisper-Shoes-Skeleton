using System;

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
    }
}