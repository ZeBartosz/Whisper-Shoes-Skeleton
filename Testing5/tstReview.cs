using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {
        //creating test data
        string CustomerName = "Peter";
        string ReviewDescription = "ReviewDescription";
        string ReviewTitle = "ReviewTitle";
        string Rating = "5";
        string DateSubmitted = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {

            clsReview aReview = new clsReview();
            Assert.IsNotNull(aReview);

        }

        [TestMethod]
        public void IsApprovedOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnReview.IsApproved = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.IsApproved, TestData);
        }

        [TestMethod]
        public void DateSubmittedOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnReview.DateSubmitted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.DateSubmitted, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "Akash";
            //assign the data to the property
            AnReview.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.CustomerName, TestData);
        }

        [TestMethod]
        public void ReviewDescriptionOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "The packaging of the item is perfect and item also looks good";
            //assign the data to the property
            AnReview.ReviewDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.ReviewDescription, TestData);
        }

        [TestMethod]
        public void ReviewTitleOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            string TestData = "About pacakging and item";
            //assign the data to the property
            AnReview.ReviewTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.ReviewTitle, TestData);
        }

        [TestMethod]
        public void RatingOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 5;
            //assign the data to the property
            AnReview.Rating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnReview.Rating, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestReviewIdFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the address id
            if (AnReview.ReviewId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the customer name
            if (AnReview.CustomerName != "CustomerName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }
        [TestMethod]
        public void TestRatingFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the rating
            if (AnReview.Rating != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateSubmittedFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the date submitted
            if (AnReview.DateSubmitted != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestReviewDescriptionFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the review description
            if (AnReview.ReviewDescription != "ReviewDescription")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }
        [TestMethod]
        public void TestReviewTitleFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the review title
            if (AnReview.ReviewTitle != "ReviewTitle")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(!OK);
        }
        [TestMethod]
        public void TestIsApprovedFound()
        {
            //create an instance of the class we want to create
            clsReview AnReview = new clsReview();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewId = 1;
            //invoke the method
            Found = AnReview.Find(ReviewId);
            //check the is approved
            if (AnReview.IsApproved != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /*************** Validation ***************/
        [TestMethod]
        public void ValidMethodOK()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }
        public void CustomerNameMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "a",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "aa",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            CustomerName = CustomerName.PadRight(49, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            CustomerName = CustomerName.PadRight(50, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            CustomerName = CustomerName.PadRight(51, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            CustomerName = CustomerName.PadRight(25, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void CustomerNameExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string CustomerName = "",
            CustomerName = CustomerName.PadRight(500, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        // Validating ReviewDescription
        [TestMethod]
        public void ReviewDescriptionMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }
        public void ReviewDescriptionMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "a",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "aa",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            ReviewDescription = ReviewDescription.PadRight(49, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            ReviewDescription = ReviewDescription.PadRight(50, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            ReviewDescription = ReviewDescription.PadRight(51, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            ReviewDescription = ReviewDescription.PadRight(25, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewDescriptionExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewDescription = "",
            ReviewDescription = ReviewDescription.PadRight(500, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        // Validating ReviewTitle
        [TestMethod]
        public void ReviewTitleMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }
        public void ReviewTitleMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "a",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "aa",
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleMaxLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            ReviewTitle = ReviewTitle.PadRight(49, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            ReviewTitle = ReviewTitle.PadRight(50, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleMaxPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            ReviewTitle = ReviewTitle.PadRight(51, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleMid()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            ReviewTitle = ReviewTitle.PadRight(25, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        public void ReviewTitleExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            string ReviewTitle = "",
            ReviewTitle = ReviewTitle.PadRight(500, 'a');
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }
        // Date Submitted
        [TestMethod]
        public void DateSubmittedExtremeMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-100);
            String DateSubmitted = TestDate.ToString();
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSubmittedMinLessOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-1);
            String DateSubmitted = TestDate.ToString();
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSubmittedMin()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String DateSubmitted = TestDate.ToString();
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateSubmittedMinPlusOne()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String DateSubmitted = TestDate.ToString();
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSubmittedExtremeMax()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(1);
            String DateSubmitted = TestDate.ToString();
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateSubmittedInvalidData()
        {
            clsReview AnReview = new clsReview();
            String Error = "";
            String DateSubmitted = "This is not a date";
            Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, DateSubmitted);
            Assert.AreNotEqual(Error, "");
        }
    }
}

        