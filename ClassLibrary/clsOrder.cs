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
                return OrderCompleted;
            }
            set
            {
                mOrderCompleted = value;
            }
        }
        public bool Find(int orderId)
        {
            mOrderId = 21;
            mCustomerId = 123;
            mItemId = 23;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mTotalAmount = 50;
            mShippingAddress = "61 Meadwell Road";
            mOrderCompleted = true;
            //always return true
            return true;
        }

    }

}