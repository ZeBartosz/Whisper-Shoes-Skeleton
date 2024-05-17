using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);

        }
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
}
}

        
