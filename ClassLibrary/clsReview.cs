using System;

namespace ClassLibrary
{
    public class clsReview
    {








        public bool Find(int reviewId)
        {
            mReviewId = 1;
            //always return true
            return true;
        }

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
    }
}