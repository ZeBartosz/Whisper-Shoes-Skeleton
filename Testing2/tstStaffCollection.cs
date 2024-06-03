using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        /***** COLLECTION METHOD TESTS****/

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set it properties
            TestItem.StaffName = "Test Name";
            TestItem.StaffEmail = "Test@email.com";
            TestItem.StaffPassword = "TestPassword";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            //add the item
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffName = "Test Staff";
            TestStaff.StaffEmail = "TestStaff@email.com";
            TestStaff.StaffPassword = "TestStaffPassword";
            TestStaff.StaffStartDate = DateTime.Now;
            TestStaff.StaffSalary = 10;
            TestStaff.StaffManager = false;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffName = "Test Name";
            TestItem.StaffEmail = "Test@email.com";
            TestItem.StaffPassword = "TestPassword";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            //add to list
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test date
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffName = "Test Name";
            TestItem.StaffEmail = "Test@email.com";
            TestItem.StaffPassword = "TestPassword";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            //set this to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffName = "Test Name";
            TestItem.StaffEmail = "Test@email.com";
            TestItem.StaffPassword = "TestPassword";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.StaffName = "Test Name";
            TestItem.StaffEmail = "Test@email.com";
            TestItem.StaffPassword = "TestPassword";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffId = 1;
            TestItem.StaffName = "Test";
            TestItem.StaffEmail = "Test@email";
            TestItem.StaffPassword = "Test";
            TestItem.StaffStartDate = DateTime.Now;
            TestItem.StaffSalary = 1;
            TestItem.StaffManager = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByStaffNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffName("");
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByStaffName("xxxxxxxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByStaffNameDataFound()
        {
            //create an instance of the filterd data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a staff name that doesnt exist
            FilteredStaff.ReportByStaffName("Test Name");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 1)
            {
                //check to see that the first record is 9
                if (FilteredStaff.StaffList[0].StaffId != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }


    }
}
