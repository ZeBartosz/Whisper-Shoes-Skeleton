using System;
using System.Runtime.InteropServices.ComTypes;

namespace ClassLibrary
{

    public class clsStock
    {

        // 
        private Int32 mStockId;
        public Int32 stockId
        {

            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }

        //
        private Boolean mAutoRestock;
        public Boolean stockAutoRestock
        {
            get 
            {                 
                return mAutoRestock; 
            }
            set
            {
                mAutoRestock = value;
            }
        }

        //
        private DateTime mStockLastRestocke;
        public DateTime stockLastRestocked
        {
            get
            {
                return mStockLastRestocke;
            }
            set 
            {
                mStockLastRestocke = value;
            }
        }

        //
        private Int32 mStockRestockThreshold;
        public Int32 stockRestockThreshold
        {
            get
            {
                return mStockRestockThreshold;
            }
            set 
            { 
                mStockRestockThreshold = value;
            }


        }

        //
        private Int32 mStockQuantity;
        public Int32 stockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set 
            {
                mStockQuantity = value; 
            }
        }

        //
        private String mStockDescription;
        public String stockDescription
        {
            get
            {
                return mStockDescription;
            }
            set 
            { 
                mStockDescription = value; 
            }
        }

        //
        private String mStockName;
        public String stockName
        {
            get 
            { 
                return mStockName; 
            }
            set 
            { 
                mStockName = value; 
            }
        }

        public bool Find(int stockId)
        {
            mStockId = 13;
            mAutoRestock = true;
            mStockLastRestocke = Convert.ToDateTime("23/12/2024");
            mStockRestockThreshold = 10;
            mStockQuantity = 20;
            mStockDescription = "this is whisper shoes";
            mStockName = "adidas";

            return true;
        }
    }
}