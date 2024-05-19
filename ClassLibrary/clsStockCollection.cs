using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        public clsStock ThisStock { get; set; }

        //private variables
        List<clsStock> mStockList = new List<clsStock>();
        private Int32 mCount;
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
        
        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock aStock = new clsStock();

                aStock.stockId = Convert.ToInt32(DB.DataTable.Rows[Index]["stockId"]);
                aStock.stockName = Convert.ToString(DB.DataTable.Rows[Index]["stockName"]);
                aStock.stockDescription = Convert.ToString(DB.DataTable.Rows[Index]["stockDescription"]);
                aStock.stockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["stockQuantity"]);
                aStock.stockRestockThreshold = Convert.ToInt32(DB.DataTable.Rows[Index]["stockRestockThreshold"]);
                aStock.stockLastRestocked = Convert.ToDateTime(DB.DataTable.Rows[Index]["stockLastRestocked"]);
                aStock.stockAutoRestock = Convert.ToBoolean(DB.DataTable.Rows[Index]["stockAutoRestock"]);


                mStockList.Add(aStock);
                Index++;
            }

        }

    }
}