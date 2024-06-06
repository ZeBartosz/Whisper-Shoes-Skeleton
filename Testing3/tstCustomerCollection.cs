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

        [TestMethod]

        public void AddMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers TestItem = new clsCustomers();
            Int32 PrimaryKey = 0;
            TestItem.Save_Payment_Info = true;
            TestItem.Customer_id = 1;
            TestItem.Customer_First_Name = "Ethan";
            TestItem.Customer_Last_Name = "Brogan";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "some street";
            TestItem.Customer_Phone_Nmbr = "07400";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Customer_id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers TestItem = new clsCustomers();
            Int32 PrimaryKey = 0;
            TestItem.Save_Payment_Info = true;
            TestItem.Customer_First_Name = "Ethan";
            TestItem.Customer_Last_Name = "Brogan";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "some street";
            TestItem.Customer_Phone_Nmbr = "07400";

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Customer_id = PrimaryKey;
            
            TestItem.Save_Payment_Info = false;
            TestItem.Customer_First_Name = "Enzo";
            TestItem.Customer_Last_Name = "Maresca";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "another street";
            TestItem.Customer_Phone_Nmbr = "07500";

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();

            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]

        public void DeleteMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers TestItem = new clsCustomers();
            Int32 PrimaryKey = 0;
            TestItem.Save_Payment_Info = true;
            TestItem.Customer_First_Name = "Ethan";
            TestItem.Customer_Last_Name = "Brogan";
            TestItem.Customer_DOB = DateTime.Now; //?
            TestItem.Customer_Address = "some street";
            TestItem.Customer_Phone_Nmbr = "07400";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Customer_id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void ReportByCustomerLastNameMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerLastName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByCustomerLastNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByCustomerLastName("xxx xxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        /*
         *        
        [TestMethod]

        public void ReportByCustomerLastNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByCustomerLastName("Test");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].Customer_id != 2038)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[0].Customer_id != 2039)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        } 
         *
         */


    }
}
