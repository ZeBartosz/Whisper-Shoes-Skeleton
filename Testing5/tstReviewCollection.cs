using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


    namespace Testing5
    {
        [TestClass]
        public class tstReviewCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsReviewCollection AllReviews = new clsReviewCollection();
                Assert.IsNotNull(AllReviews);
            }

            [TestMethod]
            public void ReviewListOK()
            {
                clsReviewCollection AllReviews = new clsReviewCollection();
                List<clsReview> TestList = new List<clsReview>();
                clsReview TestItem = new clsReview();
                //set its properties
                TestItem.ReviewId = 1;
                TestItem.CustomerName = "CustomerName";
                TestItem.ReviewDescription = "ReviewDescription";
                TestItem.ReviewTitle = "ReviewTitle";
                TestItem.Rating = 5;
                TestItem.DateSubmitted = DateTime.Now;
                TestItem.IsApproved = true;
                //add the item to the test list.
                TestList.Add(TestItem);
                AllReviews.ReviewList = TestList;
                Assert.AreEqual(AllReviews.ReviewList, TestList);
            }

            [TestMethod]
            public void ThisReviewPropertyOK()
            {
                clsReviewCollection AllReviews = new clsReviewCollection();
                clsReview TestReview = new clsReview();
                //set the properties of the test object
                TestReview.ReviewId = 1;
                TestReview.CustomerName = "CustomerName";
                TestReview.ReviewDescription = "ReviewDescription";
                TestReview.ReviewTitle = "ReviewTitle";
                TestReview.Rating = 5;
                TestReview.DateSubmitted = DateTime.Now;
                TestReview.IsApproved = true;
                //assign the data to the property
                AllReviews.ThisReview = TestReview;
                Assert.AreEqual(AllReviews.ThisReview, TestReview);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                clsReviewCollection AllReviews = new clsReviewCollection();
                List<clsReview> TestList = new List<clsReview>();
                clsReview TestItem = new clsReview();
                //set its properties
                TestItem.ReviewId = 1;
                TestItem.CustomerName = "CustomerName";
                TestItem.ReviewDescription = "ReviewDescription";
                TestItem.ReviewTitle = "ReviewTitle";
                TestItem.Rating = 5;
                TestItem.DateSubmitted = DateTime.Now;
                TestItem.IsApproved = true;
                //add the item to the test list.
                TestList.Add(TestItem);
                AllReviews.ReviewList = TestList;
                Assert.AreEqual(AllReviews.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()
            {
                //create an instance of the class we want to create
                clsReviewCollection AllReviews = new clsReviewCollection();
                //create the item of test data
                clsReview TestItem = new clsReview();
                //variable to store the primary key
                Int32 PrimaryKey = 0;
                //set its properties
                TestItem.ReviewId = 1;
                TestItem.CustomerName = "CustomerName";
                TestItem.ReviewDescription = "ReviewDescription";
                TestItem.ReviewTitle = "ReviewTitle";
                TestItem.Rating = 5;
                TestItem.DateSubmitted = DateTime.Now;
                TestItem.IsApproved = true;
                //set ThisReview to the test data
                AllReviews.ThisReview = TestItem;
                //add the record
                PrimaryKey = AllReviews.Add();
                //set the primary key of the test data
                TestItem.ReviewId = PrimaryKey;
                //find the record
                AllReviews.ThisReview.Find(PrimaryKey);
                //test to see that the two values are the same
                Assert.AreEqual(AllReviews.ThisReview, TestItem);
            }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewCollection AllReviews = new clsReviewCollection();
            //create the item of test data
            clsReview TestItem = new clsReview();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerName = "CustomerName";
            TestItem.ReviewDescription = "ReviewDescription";
            TestItem.ReviewTitle = "ReviewTitle";
            TestItem.Rating = 5;
            TestItem.DateSubmitted = DateTime.Now;
            TestItem.IsApproved = true;
            //set ThisReview to the test data
            AllReviews.ThisReview = TestItem;
            //add the record
            PrimaryKey = AllReviews.Add();
            //set the primary key of the test data
            TestItem.ReviewId = 1;
            //modify the test record
            TestItem.CustomerName = "Peter";
            TestItem.ReviewDescription = "ReviewDescription";
            TestItem.ReviewTitle = "ReviewTitle";
            TestItem.Rating = 5;
            TestItem.DateSubmitted = DateTime.Now;
            TestItem.IsApproved = false;
            //set the record based on the new test data
            AllReviews.ThisReview = TestItem;
            //update the record
            AllReviews.Update();
            //find the record
            AllReviews.ThisReview.Find(PrimaryKey);
            //test to see if ThisReview matches the test data
            Assert.AreEqual(AllReviews.ThisReview, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewCollection AllReviews = new clsReviewCollection();
            //create the item of test data
            clsReview TestItem = new clsReview();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerName = "CustomerName";
            TestItem.ReviewDescription = "ReviewDescription";
            TestItem.ReviewTitle = "ReviewTitle";
            TestItem.Rating = 5;
            TestItem.DateSubmitted = DateTime.Now;
            TestItem.IsApproved = true;
            //set ThisReview to the test data
            AllReviews.ThisReview = TestItem;
            //add the record
            PrimaryKey = AllReviews.Add();
            //set the primary key of the test data
            TestItem.ReviewId = PrimaryKey;
            //find the record
            AllReviews.ThisReview.Find(PrimaryKey);
            //delete the record
            AllReviews.Delete();
            //now find the record
            Boolean Found = AllReviews.ThisReview.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            //create an instance of the class we want to create
            clsReviewCollection AllReviews = new clsReviewCollection();
            clsReviewCollection FilteredReviews = new clsReviewCollection();
            FilteredReviews.ReportByCustomerName("");
            Assert.AreEqual(AllReviews.Count, FilteredReviews.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            clsReviewCollection FilteredReviews = new clsReviewCollection();
            FilteredReviews.ReportByCustomerName("xxxxxx");
            Assert.AreEqual(0, FilteredReviews.Count);
        }

    }
}
