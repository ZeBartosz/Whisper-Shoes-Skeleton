using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomers ACustomer = new clsCustomers();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]

        public void SavePaymentInfo()
        {
            clsCustomers ACustomer = new clsCustomers();

            Boolean TestData = true;

            ACustomer.Save_Payment_Info = TestData;

            Assert.AreEqual(ACustomer.Save_Payment_Info, TestData);
        }

        [TestMethod]

        public void CustomerFirstName()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "Ethan";

            ACustomer.Customer_First_Name = TestData;

            Assert.AreEqual(ACustomer.Customer_First_Name, TestData);
        }
        [TestMethod]

        public void CustomerLastName()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "Brogan";

            ACustomer.Customer_Last_Name = TestData;

            Assert.AreEqual(ACustomer.Customer_Last_Name, TestData);
        }
        [TestMethod]

        public void CustomerDOB()
        {
            clsCustomers ACustomer = new clsCustomers();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.Customer_DOB = TestData;

            Assert.AreEqual(ACustomer.Customer_DOB, TestData);
        }
        [TestMethod]

        public void CustomerPhoneNmbr()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "07400";

            ACustomer.Customer_Phone_Nmbr = TestData;

            Assert.AreEqual(ACustomer.Customer_Phone_Nmbr, TestData);
        }
        [TestMethod]

        public void CustomerAddress()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "107 street";

            ACustomer.Customer_Address = TestData;

            Assert.AreEqual(ACustomer.Customer_Address, TestData);
        }


    }
}