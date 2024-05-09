using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void ActiveProperty()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to property
            AnOrder.Active = TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void DataAddedPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to property
            AnOrder.DataAdded = TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.DataAdded, TestData);
        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "21";
            //assign the data to property
            AnOrder.CustomerId = TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]
        public void ItemIdPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to property
            AnOrder.ItemId = TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.ItemId, TestData);
        }
        [TestMethod]
        public void TotalAmountOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            float TestData = 50;
            //assign the data to property
            AnOrder.TotalAmount = TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }
        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create an intance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            String TestData = "61 Meadwell Road LE31SU";
            //assign the data to property
            AnOrder.ShippingAddress= TestData;
            //test to see thst the teo values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }


    }
}



    