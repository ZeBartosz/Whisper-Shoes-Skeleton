using System;

namespace ClassLibrary
{
    public class clsReview
    {
        public bool IsApproved { get; set; }
        public DateTime DateSubmitted { get; set; }
        public string CustomerName { get; set; }
        public string ReviewDescription { get; set; }
        public string ReviewTitle { get; set; }
        public int Rating { get; set; }

      
        public bool Find(int reviewId)
        {
            //always return true
            return true;
        }
        public class clsReview
        {
            //private data member for the address id property
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
            public bool Find(Int32 reviewId)
            {
                //set the private data members to the test data value
                mReviewId = 21;
                //always return true
                return true;
            
            }
         }
      }
}