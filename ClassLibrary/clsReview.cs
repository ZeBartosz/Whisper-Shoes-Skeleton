using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
        public class clsReview
        {



            //private data member for the review id property
            private Int32 mReviewId;

            //reviewId public property
            public Int32 ReviewId
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
            private String mCustomerName;

            //customername public property
            public String CustomerName
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
            public Int32 Rating
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
            private String mReviewDescription;

            //reviewdescription public property
            public String ReviewDescription
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
            private String mReviewTitle;

            //reviewtitle public property
            public String ReviewTitle
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
            public Boolean IsApproved
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
        public string Valid(string CustomerName, string ReviewDescription, string ReviewTable, string DateSubmitted)
        {
            // Variable which stores Error
            String Error = "";
            DateTime DateTemp;

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

            // ReviewDescription validation
            // Checking if the ReviewDescription variable is blank
            if (ReviewDescription.Length == 0)
            {
                Error = Error + "The Review Description may not be blank : ";
            }
            // if the ReviewDescription is more than 500
            if (ReviewDescription.Length > 500)
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

            return Error;
        }
    }
}
