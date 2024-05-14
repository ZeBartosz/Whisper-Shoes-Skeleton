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
        [TestMethod]

        public void CustomerID()
        {
            clsCustomers ACustomer = new clsCustomers();

            Int32 TestData = 1;

            ACustomer.Customer_id = TestData;

            Assert.AreEqual(ACustomer.Customer_id, TestData);
        }
        [TestMethod]

        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomers aCustomer = new clsCustomers();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Customer_id = 1;
            //invoke the method
            Found = aCustomer.Find(Customer_id);
            Assert.IsTrue(Found);
        }
        [TestMethod]

        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the the data is ok
            Boolean OK = true;
            //create some test date
            Int32 Customer_id = 1;
            //invoke the method
            Found = ACustomer.Find(Customer_id);
            //check the Customer ID
            if (ACustomer.Customer_id != 1)
            {
                OK = false;
            }
            //test to see thate the result is correct
            Assert.IsTrue(OK);
            
        }





    }
}