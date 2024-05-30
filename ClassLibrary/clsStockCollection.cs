using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private variables
        List<clsStock> mStockList = new List<clsStock>();
        //private Int32 mCount;
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get 
            { 
                return mStockList; 
            }
            set 
            { 
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
        
        // Constructor class
        public clsStockCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            // populate the array list with data table
            PopulateArray(DB);

        }

        // populates the array list based on the data table in the paremeter DB
        void PopulateArray(clsDataConnection DB)
        {
            // Variable for the index
            Int32 Index = 0;
            // variable to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the pricate array list
            mStockList = new List<clsStock>();
            // while there are record to process 
            while (Index < RecordCount)
            {
                // create a blank stock object
                clsStock aStock = new clsStock();
                // read in the fields from the current records
                aStock.stockId = Convert.ToInt32(DB.DataTable.Rows[Index]["stockId"]);
                aStock.stockName = Convert.ToString(DB.DataTable.Rows[Index]["stockName"]);
                aStock.stockDescription = Convert.ToString(DB.DataTable.Rows[Index]["stockDescription"]);
                aStock.stockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["stockQuantity"]);
                aStock.stockRestockThreshold = Convert.ToInt32(DB.DataTable.Rows[Index]["stockRestockThreshold"]);
                aStock.stockLastRestocked = Convert.ToDateTime(DB.DataTable.Rows[Index]["stockLastRestocked"]);
                aStock.stockAutoRestock = Convert.ToBoolean(DB.DataTable.Rows[Index]["stockAutoRestock"]);
                // add the record to the private data member 
                mStockList.Add(aStock);
                // point at the next record 
                Index++;
            }
        }

        // Adds a record to the database based on the values of mThisStock
        public int Add()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@stockName", mThisStock.stockName);
            DB.AddParameter("@stockDescription", mThisStock.stockDescription);
            DB.AddParameter("@stockQuantity", mThisStock.stockQuantity);
            DB.AddParameter("@stockRestockThreshold", mThisStock.stockRestockThreshold);
            DB.AddParameter("@stockLastRestocked", mThisStock.stockLastRestocked);
            DB.AddParameter("@stockAutoRestock", mThisStock.stockAutoRestock);
            // Executes the procedure
            return DB.Execute("sproc_tblStock_Insert");
        }

        // Updates an existing record based on the vakues of this address
        public void Update()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@stockId", mThisStock.stockId);
            DB.AddParameter("@stockName", mThisStock.stockName);
            DB.AddParameter("@stockDescription", mThisStock.stockDescription);
            DB.AddParameter("@stockQuantity", mThisStock.stockQuantity);
            DB.AddParameter("@stockRestockThreshold", mThisStock.stockRestockThreshold);
            DB.AddParameter("@stockLastRestocked", mThisStock.stockLastRestocked);
            DB.AddParameter("@stockAutoRestock", mThisStock.stockAutoRestock);
            // Executes the procedure
            DB.Execute("sproc_tblStock_Update");
        }

        // delete the record pointed to by ThisStock
        public void Delete()
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@stockId", mThisStock.stockId);
            // excute the procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        // filters the record based on a full or partial post code 
        public void ReportByStockName(string stockName)
        {
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the stockName param
            DB.AddParameter("@stockName", stockName);
            // excute the stored procedure
            DB.Execute("sproc_tblStock_filterByStockName");
            // popilate the array list with data table
            PopulateArray(DB);
        }
    }
}