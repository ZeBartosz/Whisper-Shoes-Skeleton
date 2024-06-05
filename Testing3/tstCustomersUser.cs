using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomersUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            Assert.IsNotNull(AUser);
        }

        [TestMethod]

        public void UserIDPropertyOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            Int32 TestData = 1;
            AUser.UserID = TestData;
            Assert.AreEqual(AUser.UserID, TestData);

        }

        [TestMethod]

        public void UserNamePropertyOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            string TestData = "Ethan";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }

        [TestMethod]

        public void PasswordPropertyOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            string TestData = "Password";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]

        public void DepartmentPropertyOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            string TestData = "Customer";
            AUser.Department = TestData;
            Assert.AreEqual(AUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK()
        {
            clsCustomersUser AUser = new clsCustomersUser();
            Boolean Found = false;
            string UserName = "Ethan";
            string Password = "Password";
            Found = AUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            // create an instance of the class 
            clsCustomersUser AUser = new clsCustomersUser();
            // create a boolean variable to store 
            Boolean Found = false;
            // create a boolean record
            Boolean OK = true;
            // create test data
            string UserName = "Ethan";
            string Password = "Password";
            // invoke the method
            Found = AUser.FindUser(UserName, Password);
            // check the user id property 
            if (AUser.UserName != UserName && AUser.Password != Password)
            {
                OK = false;
            }
            // test 
            Assert.IsTrue(OK);
        }
    }
}
