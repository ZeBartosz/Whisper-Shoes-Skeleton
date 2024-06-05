using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
        public class clsReview
        {
            //private data member for the review id property
            private Int32 mReviewId;

            //reviewId public property
            public int ReviewId
            {
                get
                {
                    //this line of code sends data out of the property
                    return mReviewId;
                }
                set
                {
                    //this line of code allows data into property
                    mReviewId = value;
                }
            }

            //private data member for the review id property
            private string mCustomerName;

            //customername public property
            public string CustomerName
            {
                get
                {
                    //this line of code sends data out of the property
                    return mCustomerName;
                }
                set
                {
                    //this line of code allows data into property
                    mCustomerName = value;
                }
            }
            //private data member for the review id property
            private Int32 mRating;

            //rating public property
            public int Rating
            {
                get
                {
                    //this line of code sends data out of the property
                    return mRating;
                }
                set
                {
                    //this line of code allows data into property
                    mRating = value;
                }
            }
            //private data member for the review id property
            private DateTime mDateSubmitted;

            //datesubmitted public property
            public DateTime DateSubmitted
            {
                get
                {
                    //this line of code sends data out of the property
                    return mDateSubmitted;
                }
                set
                {
                    //this line of code allows data into property
                    mDateSubmitted = value;
                }
            }
            //private data member for the review id property
            private string mReviewDescription;

            //reviewdescription public property
            public string ReviewDescription
            {
                get
                {
                    //this line of code sends data out of the property
                    return mReviewDescription;
                }
                set
                {
                    //this line of code allows data into property
                    mReviewDescription = value;
                }
            }
            //private data member for the review id property
            private string mReviewTitle;

            //reviewtitle public property
            public string ReviewTitle
            {
                get
                {
                    //this line of code sends data out of the property
                    return mReviewTitle;
                }
                set
                {
                    //this line of code allows data into property
                    mReviewTitle = value;
                }
            }
            //private data member for the review id property
            private Boolean mIsApproved;

            //isapproved public property
            public bool IsApproved
            {
                get
                {
                    //this line of code sends data out of the property
                    return mIsApproved;
                }
                set
                {
                    //this line of code allows data into property
                    mIsApproved = value;
                }
            }

        
        public bool Find(int ReviewId)

            {

                //create an instance of the data connection

                clsDataConnection DB = new clsDataConnection();

                //add the parameter for the address id to search for

                DB.AddParameter("@ReviewId", ReviewId);

                //execute the stored procedure

                DB.Execute("sproc_tblReview_FilterByReviewId");

                //if one record is found (there should be either one or zero)

                if (DB.Count == 1)

                {

                    //copy the data from the database to the private data members

                    mReviewId = Convert.ToInt32(DB.DataTable.Rows[0]["ReviewId"]);
                    mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                    mRating = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                    mDateSubmitted = Convert.ToDateTime(DB.DataTable.Rows[0]["DateSubmitted"]);
                    mReviewDescription = Convert.ToString(DB.DataTable.Rows[0]["ReviewDescription"]);
                    mReviewTitle = Convert.ToString(DB.DataTable.Rows[0]["ReviewTitle"]);
                    mIsApproved = Convert.ToBoolean(DB.DataTable.Rows[0]["IsApproved"]);

                    //return that everything worked OK

                    return true;
                }
                else
                {
                    return false;
                }
            }
        public string Valid(string CustomerName, string ReviewDescription, string ReviewTitle, string Rating, string DateSubmitted)
        {
            // Variable which stores Error
            String Error = "";
            DateTime DateTemp;
            int RatingValue;

            // CustomerName validation
            // Checking if the CustomerName variable is blank
            if (CustomerName.Length == 0)
            {
                Error = Error + "The Customer Name may not be blank : ";
            }
            // if the CustomerName is more than 50
            if (CustomerName.Length > 50)
            {
                Error = Error + "The Customer Name has to contain less than 50 characters : ";
            }
          /*  if (Rating.Length == 0)
            {
                Error = Error + "The Rating may not be less than 1 : ";
            }
            // if the ReviewDescription is more than 500
            if (Rating.Length < 6)
            {
                Error = Error + "The Rating must be less than 6 ";
            }*/

            // ReviewDescription validation
            // Checking if the ReviewDescription variable is blank
            if (ReviewDescription.Length == 0)
            {
                Error = Error + "The Review Description may not be blank : ";
            }
            // if the ReviewDescription is more than 500
            if (ReviewDescription.Length > 1000)
            {
                Error = Error + "The Review Description has to contain less than 500 characters : ";
            }
            // ReviewTitle validation
            // Checking if the ReviewTitle variable is blank
            if (ReviewTitle.Length == 0)
            {
                Error = Error + "The Review Title may not be blank : ";
            }
            // if the ReviewTitle is more than 50
            if (ReviewTitle.Length > 50)
            {
                Error = Error + "The Review Title has to contain less than 50 characters : ";
            }

            // DateSubmitted validation
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                // Copy the DateSubmitted value to the DateTemp and convert it back to dateTime
                DateTemp = Convert.ToDateTime(DateSubmitted);

                // Checking if the date is less than the time right now
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date can't be in the past : ";
                }
                // Checking if the date is more than the time right now 
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date can't be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was invaid date";
            }
            if (!int.TryParse(Rating, out RatingValue))
            {
                Error += "The Rating must be a number: ";
            }
            else
            {
                if (RatingValue < 1)
                {
                    Error += "The Rating cannot be less than 1: ";
                }
                if (RatingValue > 5)
                {
                    Error += "The Rating cannot be more than 5: ";
                }
            }

            return Error;
        }
    }
}
