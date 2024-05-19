using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        /****TEST DATA****/
        string StaffName = "Test Name";
        string StaffEmail = "Test@email.com";
        string StaffPassword = "Password";
        string StaffStartDate = DateTime.Now.ToShortDateString();


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
            Staff.StaffManager = TestData;
            Assert.AreEqual(Staff.StaffManager, TestData);

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
            Int32 StaffId = 1;
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
            Int32 StaffId = 1;
            //invoke the method
            Found = Staff.Find(StaffId);
            //check the staff id 
            if (Staff.StaffId != 1)
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffName != "James Roberts") 
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffEmail != "james20@gmail.com")
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffPassword != "JPassword20")
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffStartDate != Convert.ToDateTime("01/05/2024"))
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffSalary != 400000)
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
            Int32 StaffId = 1;
            Found = Staff.Find(StaffId);
            if (Staff.StaffManager != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        /*****VALIDATION TESTS*****/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsStaff Staff = new clsStaff();
            //string variable to store error message
            String Error = "";
            //invoke the method
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            //test to see if result is correct
            Assert.AreEqual(Error, Error);
        }
        /*****STAFFNAME TESTS*****/
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            //test to see if that result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "a";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(69, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(70, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(71, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        
        public void StaffNameMid()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(35, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(250, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        /*****STAFFSTARTDATE*****/
        [TestMethod]
        public void StaffStartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StaffStartDate = TestDate.ToString();
            //invoke the method
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMinLessOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StaffStartDate = TestDate.ToString();
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMin()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StaffStartDate = TestDate.ToString();
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffStartDateMinPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StaffStartDate = TestDate.ToString();
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffStartDateExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StaffStartDate = TestDate.ToString();
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffStartDate = "This is not a date!";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        /*****STAFFEMAIL*****/

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "a@";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            //test to see if that result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "a@a";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "a@aa";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(54, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(55, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(56, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(29, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffName = StaffEmail.PadRight(250, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        /*****STAFFPASSWORD*****/
        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "aaaaa";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            //test to see if that result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "aaaaaa";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "aaaaaaa";
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(19, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(20, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(56, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(13, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(100, 'a');
            Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}

        
