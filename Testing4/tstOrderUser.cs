using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {

            [TestMethod]
            public void InstanceOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                Assert.IsNotNull(AnUser);
            }


            [TestMethod]
            public void UserIdPropertyOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                Int32 TestData = 1;
                AnUser.UserId = TestData;
                Assert.AreEqual(AnUser.UserId, TestData);
            }


            [TestMethod]
            public void UsernNmePropertyOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                string TestData = "Tarar";
                AnUser.UserName = TestData;
                Assert.AreEqual(AnUser.UserName, TestData);
            }


            [TestMethod]
            public void PasswordPropertyOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                string TestData = "Tarar12@@";
                AnUser.Password = TestData;
                Assert.AreEqual(AnUser.Password, TestData);
            }



            [TestMethod]
            public void DepartmentPropertyOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                string TestData = "Orders Department";

                AnUser.Department = TestData;
                Assert.AreEqual(AnUser.Department, TestData);
            }

            [TestMethod]

            public void FindUserMethodOK()
            {
                clsOrderUser AnUser = new clsOrderUser();
                Boolean Found = false;
                string UserName = "Usama Tarar";
                string Password = "123456";
                Found = AnUser.FindUser(UserName, Password);
                Assert.IsTrue(Found);
            }

            [TestMethod]

            public void TestUsernamePWFound()
            {
                clsOrderUser AnUser = new clsOrderUser();
                Boolean Found = false;
                Boolean Ok = true;
                string UserName = "Usama Tarar";
                string Password = "123456";
            Found = AnUser.FindUser(UserName, Password);

                if (AnUser.UserName != UserName && AnUser.Password != Password)
                {
                    Ok = false;
                }
                Assert.IsTrue(Ok);
            
        }
    }
}
