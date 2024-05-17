using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
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
            Int32 TestData =22;
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
            Int32 OrderId = 21;
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if(AnOrder.OrderId !=21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {  clsOrder AnOrder = new clsOrder();
            Boolean Found = false; 
            Boolean OK = true;
            Int32 OrderId = 21;
            Found= AnOrder.Find(OrderId);
            if(AnOrder.CustomerId !=123)
            { 
            OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemIdFound()
        { clsOrder AnOrder = new clsOrder();
        Boolean Found = false;
        Boolean OK = true;
        Int32 OrderId = 21;
        Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemId != 23)
            {  OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDateFound()
        { clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("23/12/2022"))
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.TotalAmount!= 50)
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ShippingAddress != "61 Meadwell Road")
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
            Int32 OrderId = 21;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderCompleted != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}



    