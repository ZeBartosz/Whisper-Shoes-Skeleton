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

       
    }
}