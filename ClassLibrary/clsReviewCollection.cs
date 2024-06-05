using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsReviewCollection
    {
        List<clsReview> mReviewList = new List<clsReview>();
        clsReview mThisReview = new clsReview();

        public List<clsReview> ReviewList
        {
            get
            {
                return mReviewList;
            }
            set
            {
                mReviewList = value;
            }
        }

        public int Count
        {
            get
            {
                return mReviewList.Count;
            }
            set
            {

            }
        }
        public clsReview ThisReview
        {

            get
            {
                return mThisReview;
            }
            set
            {
                mThisReview = value;
            }
        }

        public clsReviewCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblReview_SelectAll");
            PopulateArray(DB);
        }


        //MODIFY UPPER PROPERTY.........................

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisReview.CustomerName);
            DB.AddParameter("@ReviewDescription", mThisReview.ReviewDescription);
            DB.AddParameter("@ReviewTitle", mThisReview.ReviewTitle);
            DB.AddParameter("@Rating", mThisReview.Rating);
            DB.AddParameter("@DateSubmitted", mThisReview.DateSubmitted);
            DB.AddParameter("@IsApproved", mThisReview.IsApproved);

            return DB.Execute("sproc_tblReview_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewId", mThisReview.ReviewId);
            DB.AddParameter("@CustomerName", mThisReview.CustomerName);
            DB.AddParameter("@ReviewDescription", mThisReview.ReviewDescription);
            DB.AddParameter("@ReviewTitle", mThisReview.ReviewTitle);
            DB.AddParameter("@Rating", mThisReview.Rating);
            DB.AddParameter("@DateSubmitted", mThisReview.DateSubmitted);
            DB.AddParameter("@IsApproved", mThisReview.IsApproved);

            DB.Execute("sproc_tblReview_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ReviewId", mThisReview.ReviewId);
            DB.Execute("sproc_tblReview_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("sproc_tblReview_FilterByCustomerName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mReviewList = new List<clsReview>();
            while (Index < RecordCount)
            {
                clsReview AnReview = new clsReview();
                AnReview.ReviewId = Convert.ToInt32(DB.DataTable.Rows[Index]["ReviewId"]);
                AnReview.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnReview.ReviewDescription = Convert.ToString(DB.DataTable.Rows[Index]["ReviewDescription"]);
                AnReview.ReviewTitle = Convert.ToString(DB.DataTable.Rows[Index]["ReviewTitle"]);
                AnReview.Rating = Convert.ToInt32(DB.DataTable.Rows[Index]["Rating"]);
                AnReview.DateSubmitted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateSubmitted"]);
                AnReview.IsApproved = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsApproved"]);

                mReviewList.Add(AnReview);

                Index++;
            }
        }
    }
}