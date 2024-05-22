using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{

    [TestClass]
    public class tstCustomers
    {
        //good test data
        //create some test data to pass the method
        string Customer_First_Name = "Ethan";
        string Customer_Last_Name = "Brogan";
        string Customer_DOB = "19/02/2004";
        string Customer_Address = "107 street";
        string Customer_Phone_Nmbr = "07400";


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomers ACustomer = new clsCustomers();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]

        public void SavePaymentInfo()
        {
            clsCustomers ACustomer = new clsCustomers();

            Boolean TestData = true;

            ACustomer.Save_Payment_Info = TestData;

            Assert.AreEqual(ACustomer.Save_Payment_Info, TestData);
        }

        [TestMethod]

        public void CustomerFirstName()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "Ethan";

            ACustomer.Customer_First_Name = TestData;

            Assert.AreEqual(ACustomer.Customer_First_Name, TestData);
        }
        [TestMethod]

        public void CustomerLastName()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "Brogan";

            ACustomer.Customer_Last_Name = TestData;

            Assert.AreEqual(ACustomer.Customer_Last_Name, TestData);
        }
        [TestMethod]

        public void CustomerDOB()
        {
            clsCustomers ACustomer = new clsCustomers();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.Customer_DOB = TestData;

            Assert.AreEqual(ACustomer.Customer_DOB, TestData);
        }
        [TestMethod]

        public void CustomerPhoneNmbr()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "07400";

            ACustomer.Customer_Phone_Nmbr = TestData;

            Assert.AreEqual(ACustomer.Customer_Phone_Nmbr, TestData);
        }
        [TestMethod]

        public void CustomerAddress()
        {
            clsCustomers ACustomer = new clsCustomers();

            String TestData = "107 street";

            ACustomer.Customer_Address = TestData;

            Assert.AreEqual(ACustomer.Customer_Address, TestData);
        }
        [TestMethod]

        public void CustomerID()
        {
            clsCustomers ACustomer = new clsCustomers();

            Int32 TestData = 1;

            ACustomer.Customer_id = TestData;

            Assert.AreEqual(ACustomer.Customer_id, TestData);
        }
        [TestMethod]

        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomers aCustomer = new clsCustomers();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Customer_id = 1;
            //invoke the method
            Found = aCustomer.Find(Customer_id);
            Assert.IsTrue(Found);
        }

        //Find methods------------------------------
        [TestMethod]

        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the the data is ok
            Boolean OK = true;
            //create some test date
            Int32 Customer_id = 1;
            //invoke the method
            Found = ACustomer.Find(Customer_id);
            //check the Customer ID
            if (ACustomer.Customer_id != 1)
            {
                OK = false;
            }
            //test to see thate the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]

        public void TestCustomerFirstNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Customer_First_Name != "Ethan")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCustomerLastNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Customer_Last_Name != "Brogan")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomersDOBFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Customer_DOB != Convert.ToDateTime("19/02/2004"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerPhoneNmbrFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Customer_Phone_Nmbr != "07400")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestCustomerAddressFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Customer_Address != "22 street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestSavePaymentInfoFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Customer_id = 1;
            Found = ACustomer.Find(Customer_id);
            if (ACustomer.Save_Payment_Info != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod] // validation tests----------------------------

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            string Error = "";
            //invoke method
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //validate customer first name
        [TestMethod]

        public void CustomerFirstNameMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "";
            //invoke method
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void CustomerFirstNameMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error =  "";
            string Customer_First_Name = "a";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerFirstNameMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "aa";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerFirstNameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // max minus one is 49
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        
        public void CustomerFirstNameMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max is 50
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerFirstNameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max plus one is 51
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerFirstNameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_First_Name = "";
            Customer_First_Name.PadRight(500, 'a');
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }
        //------validate customer last name

        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "";
            //invoke method
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void CustomerLastNameMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "a";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "aa";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerLastNameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // max minus one is 49
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerLastNameMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max is 50
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerLastNameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max plus one is 51
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerLastNameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Last_Name = "";
            Customer_Last_Name.PadRight(500, 'a');
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        //-------------Validate Customer Address
        [TestMethod]

        public void CustomerAddressMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "";
            //invoke method
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void CustomerAddressMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "a";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerAddressMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "aa";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerAddressMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // max minus one is 49
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerAddressMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max is 50
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //max plus one is 51
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerAddressExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Address = "";
            Customer_Address.PadRight(500, 'a');
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        // Validate customer phone number -------------
        [TestMethod]

        public void CustomerPhoneNmbrMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "";
            //invoke method
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void CustomerPhoneNmbrMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "a";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerPhoneNmbrMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "aa";
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerPhoneNmbrMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "aaaaaaaaa"; // max minus one is 9
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerPhoneNmbrMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "aaaaaaaaaa"; //max is 10
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPhoneNmbrMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "aaaaaaaaaaa"; //max plus one is 11
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPhoneNmbrExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Customer_Phone_Nmbr = "";
            Customer_Phone_Nmbr.PadRight(500, 'a');
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreNotEqual(Error, "");
        }
        //Need to do customer dob practical 10
        [TestMethod]

        public void CustomerDOBExtremeMin()    //date cannot be more than 100 years in the past
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.AddYears(-100);
            string Customer_DOB = TestDate.ToString();
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerDOBMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.AddYears(-16);
            string Customer_DOB = TestDate.ToString();
            Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
            Assert.AreEqual(Error, "");

        }
        //min -1 = 15
        //min + 1 = 17

            

    }

}