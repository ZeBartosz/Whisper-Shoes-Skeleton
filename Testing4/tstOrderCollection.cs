using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstantOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();    
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderCompleted = true;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.TotalAmount = 55;
            TestList.Add(TestOrder);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestOrder= new clsOrder();
            TestOrder.OrderCompleted = true;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.TotalAmount = 55;
            AllOrder.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderCompleted = true;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.TotalAmount = 55;
            TestList.Add(TestOrder);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.CustomerId = 1;
            TestOrder.ItemId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 55;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.OrderCompleted = true;
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }

        [TestMethod]
        public void EditMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.CustomerId = 1;
            TestOrder.ItemId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 55;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.OrderCompleted = true;

            AllOrders.ThisOrder = TestOrder;

            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            TestOrder.CustomerId = 2;
            TestOrder.ItemId = 3;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 90;
            TestOrder.ShippingAddress = "61 Leicester Road";
            TestOrder.OrderCompleted = false;
            AllOrders.ThisOrder = TestOrder;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            Int32 PrimaryKey = 0;

            TestOrder.OrderId = PrimaryKey;
            TestOrder.CustomerId = 1;
            TestOrder.ItemId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 55;
            TestOrder.ShippingAddress = "61 Meadwell Road";
            TestOrder.OrderCompleted = true;

            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }



        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShippingAddress("");

            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);


        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByShippingAddress("Usamammmamz");
            Assert.AreEqual(0, FilteredOrders.Count);
        }


        [TestMethod]

        public void ReportByShippingAddressTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByShippingAddress("61 Meadwell Road");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderId != 24)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[0].OrderId != 25)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
}
