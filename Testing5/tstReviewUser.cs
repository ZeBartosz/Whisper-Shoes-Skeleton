using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReviewUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            string TestData = "Akash";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            string TestData = "shoes123";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentIDPropertyOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            string TestData = "Review";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsReviewUser AnUser = new clsReviewUser();
            Boolean Found = false;
            string UserName = "Akash";
            string Password = "shoes123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsReviewUser AnUser = new clsReviewUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Akash";
            string Password = "shoes123";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}

