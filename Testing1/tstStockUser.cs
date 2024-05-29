using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // test to see that it exists
            Assert.IsNotNull(anUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
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
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // create some test data to assign to the proprty
            string TestData = "Bartosz";
            // assign the data to the property
            anUser.UserName = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(anUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // create some test data to assign to the proprty
            string TestData = "password123";
            // assign the data to the property
            anUser.UserPassword = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(anUser.UserPassword, TestData);
        }

        [TestMethod]
        public void DepartmentOK()
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // create some test data to assign to the proprty
            string TestData = "stock";
            // assign the data to the property
            anUser.Department = TestData;
            // test to see that the two values are the same 
            Assert.AreEqual(anUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // create a boolean variable to store 
            Boolean Found = false;
            // create test data
            string UserName = "Bartosz";
            string Password = "password123";
            // invoke the method
            Found = anUser.FindUser(UserName, Password);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound() 
        {
            // create an instance of the class 
            clsStockUser anUser = new clsStockUser();
            // create a boolean variable to store 
            Boolean Found = false;
            // create a boolean record
            Boolean OK = true;
            // create test data
            string UserName = "Bartosz";
            string Password = "password123";
            // invoke the method
            Found = anUser.FindUser(UserName, Password);
            // check the user id property 
            if (anUser.UserName != UserName && anUser.UserPassword != Password)
            {
                OK = false;
            }
            // test 
            Assert.IsTrue(OK);
        }

    }
}
