using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]

        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //Add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            TestItem.Save_Payment_Info = true;
            TestItem.Customer_id = 1;
            TestItem.Customer_First_Name = "Ethan";
            TestItem.Customer_Last_Name = "Brogan";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "some street";
            TestItem.Customer_Phone_Nmbr = "07400";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]

        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers ACustomer = new clsCustomers();
            ACustomer.Save_Payment_Info = true;
            ACustomer.Customer_id = 1;
            ACustomer.Customer_First_Name = "Ethan";
            ACustomer.Customer_Last_Name = "Brogan";
            ACustomer.Customer_DOB = DateTime.Now; //?
            ACustomer.Customer_Address = "some street";
            ACustomer.Customer_Phone_Nmbr = "07400";

            AllCustomers.ThisCustomer = ACustomer;
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to property
            //in this case the data needs to be a list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //Add an item to the list
            //create the item of test data
            clsCustomers TestItem = new clsCustomers();
            TestItem.Save_Payment_Info = true;
            TestItem.Customer_id = 1;
            TestItem.Customer_First_Name = "Ethan";
            TestItem.Customer_Last_Name = "Brogan";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "some street";
            TestItem.Customer_Phone_Nmbr = "07400";
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }
}
