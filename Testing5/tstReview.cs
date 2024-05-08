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
    }
}


