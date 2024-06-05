using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string CustomerId = "15";
        string ItemId = "31";
        string OrderDate = DateTime.Now.ToShortDateString();
        string TotalAmount = "60.99";
        string ShippingAddress = "london road";
        [TestMethod]
        public void InstanceOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);

        }
        [TestMethod]

        public void OrderCompletedPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderCompleted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderCompleted, TestData);
        }
        [TestMethod]

        public void CustomerIdPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 22;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]

        public void ItemIdPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            AnOrder.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemId, TestData);
        }
        [TestMethod]

        public void OrderDatePropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]

        public void TotalAmountPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            float TestData = 50;
            //assign the data to the property
            AnOrder.TotalAmount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }
        [TestMethod]

        public void ShippingAddressPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "61 Meadwell Road le31su";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }
        [TestMethod]

        public void OrderIdPropertyOK()
        { //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        /***************Find Method***************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 6;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        /***************PROPERTY DATA TEST***************/
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 15)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemId != 31)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("01/07/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.TotalAmount != 60)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ShippingAddress != "london road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderCompletedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 6;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderCompleted != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        /*************** Validation ***************/
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        //Validating CustomerId
        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "1";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "11";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(49, '1');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(50, '1');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(52, '1');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(25, '1');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerId = "";
            CustomerId = CustomerId.PadRight(500, '1');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }
        //Validating ItemId
        [TestMethod]
        public void ItemIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "2";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "22";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "22222";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "222222";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "222";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "2222222";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemIdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemId = "";
            ItemId = ItemId.PadRight(500, '2');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        //Validating 
        [TestMethod]
        public void ShippingAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "a";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aa";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaa";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaa";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaa";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "aaaaaaa";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(60, 'a');
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-100);
            String OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-1);
            String OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlustOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDate = "This is not a date";
            Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, TotalAmount, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }




    }
}


    