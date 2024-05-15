using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        /*****INSTANCE OF CLASS TEST*****/

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);

        }

        /*****PROPERTY OK TESTS*****/

        [TestMethod]
        public void StaffManagerPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            Boolean TestData = true;
            Staff.ManagerActive = TestData;
            Assert.AreEqual(Staff.ManagerActive, TestData);

        }
        [TestMethod]
        public void StaffStartDatePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            Staff.StaffStartDate = TestData;
            Assert.AreEqual(Staff.StaffStartDate, TestData);

        }
        
        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            clsStaff Staff = new clsStaff();
           float TestData = 1;
            Staff.StaffSalary = TestData;
            Assert.AreEqual(Staff.StaffSalary, TestData);
        
            
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Name";
            Staff.StaffName = TestData;
            Assert.AreEqual(Staff.StaffName, TestData);

        }
        [TestMethod]
        public void StaffEmailPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Email";
            Staff.StaffEmail = TestData;
            Assert.AreEqual(Staff.StaffEmail, TestData);

        }
        [TestMethod]
        public void StaffPasswordPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            string TestData = "Password";
            Staff.StaffPassword = TestData;
            Assert.AreEqual(Staff.StaffPassword, TestData);

        }

        /*****FIND METHOD TEST*****/

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //create a Boolean variable to store results of validation
            Boolean Found = false;
            //create some test data
            Int32 StaffId = 21;
            //invoke the method 
            Found = Staff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /*****PROPERTY DATA TESTS*****/

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance
            clsStaff Staff = new clsStaff();
            //create a boolean variable to store result
            Boolean Found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data 
            Int32 StaffId = 21;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the staff id 
            if (Staff.StaffId != 21)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);  
        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.StaffName != "Test Name")
            {
                OK =false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.StaffEmail != "Test@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.StaffPassword != "TestPassword")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStartDateFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.StaffStartDate != Convert.ToDateTime("15/05/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestStaffSalaryFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.StaffSalary != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestStaffManagerFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 21;
            Found = Staff.Find(StaffId);
            if (Staff.ManagerActive != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}

        
