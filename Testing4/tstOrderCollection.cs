using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        private object mOrderList;

        public object TestOrderId { get; private set; }

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
            clsOrder TestItem = new clsOrder();
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.ItemId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "61 Meadwell Road";
            TestItem.TotalAmount = 55;
            TestList.Add(TestItem);
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
            TestOrder.ItemId = 1;
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
            clsOrder TestItem = new clsOrder();
            TestItem.OrderCompleted = true;
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.ItemId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ShippingAddress = "61 Meadwell Road";
            TestItem.TotalAmount = 55;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
       
    }
}
