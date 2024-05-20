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
            TestItem.StaffStartDate= DateTime.Now;
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

    }
}
