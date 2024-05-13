using System;
using System.IO;
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
            //creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter
            DB.AddParameter("@stockId", stockId);
            //execute the stored procedure
            DB.Execute("sproc_tblstock_FilterbyStockId");
            //looking for record
            if (DB.Count == 1 ) 
            {
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["stockId"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["stockName"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["stockDescription"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["stockQuantity"]);
                mStockRestockThreshold = Convert.ToInt32(DB.DataTable.Rows[0]["stockRestockThreshold"]);
                mStockLastRestocke = Convert.ToDateTime(DB.DataTable.Rows[0]["stockLastRestocked"]);
                mAutoRestock = Convert.ToBoolean(DB.DataTable.Rows[0]["stockAutoRestock"]);
                
                return true;
            }
            else
            {
                return false;
            }

         
        }

        public string Valid(string stockName, string stockDescription, string stockQuantity, string stockRestockThreshold, string stockLastRestocked)
        {
            // Variable which stores Error
            String Error = "";
            // if the StockName is blank
            if (stockName.Length == 0) {
                Error = Error + "The stock name may not be blank : ";
            }
            // if the StockName is more than 50
            if (stockName.Length > 50) {
                Error = Error + "The Stock name has to contain less than 50 characters : ";
            }


            
            return Error;
        }
    }
}