using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser anUser = new clsStaffUser();
            Assert.IsNotNull(anUser);
        }
        /***** PROPERTY TESTS *****/

        [TestMethod]
        public void UserIdPropertyOK()
        {
            // create an instance of the class 
            clsStaffUser anUser = new clsStaffUser();
            // create some test data to assign to the proprty
            Int32 TestData = 1;
            // assign the data to the property
            anUser.UserId = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(anUser.UserId, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaffUser anUser = new clsStaffUser();
            string TestData = "James";
            anUser.UserName = TestData;
            Assert.AreEqual(anUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaffUser anUser = new clsStaffUser();
            string TestData = "pass1234";
            anUser.Password = TestData;
            Assert.AreEqual(anUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaffUser anUser = new clsStaffUser();
            string TestData = "Staff";
            anUser.Department = TestData;
            Assert.AreEqual(anUser.Department, TestData);
        }

        /***** FINDUSER METHOD *****/

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsStaffUser anUser = new clsStaffUser();
            Boolean Found = false;
            string UserName = "James";
            string Password = "pass1234";
            Found = anUser.FindUser(UserName, Password);    
            Assert.IsTrue(Found);
        }
    }
}
