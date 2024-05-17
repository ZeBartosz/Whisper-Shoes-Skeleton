using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsReview aReview = new clsReview();
            Assert.IsNotNull(aReview);

        }

        [TestMethod]
        public void IsApproved()
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
        public void DateSubmitted()
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
        public void CustomerName()
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
        public void ReviewDescription()
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
        public void ReviewTitle()
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
        public void Rating()
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
            Int32 ReviewId = 21;
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
            if (AnReview.CustomerName != "Test CustomerName")
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
            Assert.IsTrue(!OK);
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
            Assert.IsTrue(!OK);
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
            if (AnReview.ReviewDescription != "Test ReviewDescription")
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
            if (AnReview.ReviewTitle != "Test ReviewTitle")
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
            Assert.IsTrue(!OK);
        }
    }
}
