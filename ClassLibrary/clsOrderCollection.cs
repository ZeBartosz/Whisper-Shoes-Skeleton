using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrder = new List<clsOrder>();
        private List<clsOrder> mOrderList;
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sporc_tblOrder_SelectALL");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.ItemId = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateTime"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.TotalAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalAmount"]);
                mOrderList.Add(AnOrder);
                Index++;


            }
        }


    }

}