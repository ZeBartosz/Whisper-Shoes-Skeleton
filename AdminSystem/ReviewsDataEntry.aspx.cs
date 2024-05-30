using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ReviewId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewId = Convert.ToInt32(Session["ReviewId"]);

        if (IsPostBack == false)
        {
            if (ReviewId != -1)
            {
                DisplayReview();
            }
        }
    }

    void DisplayReview()
    {
        clsReviewCollection Review = new clsReviewCollection();
        Review.ThisReview.Find(ReviewId);
        txtReviewId.Text = Review.ThisReview.ReviewId.ToString();
        txtCustomerName.Text = Review.ThisReview.CustomerName.ToString();
        txtReviewDescription.Text = Review.ThisReview.ReviewDescription.ToString();
        txtReviewTitle.Text = Review.ThisReview.ReviewTitle.ToString();
        txtRating.Text = Review.ThisReview.Rating.ToString();
        txtDateSubmitted.Text = Review.ThisReview.DateSubmitted.ToString();
        chkIsApproved.Checked = Review.ThisReview.IsApproved;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsReview
        clsReview AnReview = new clsReview();
        //capture the CustomerName
        String CustomerName = txtCustomerName.Text;
        String ReviewDescription = txtReviewDescription.Text;
        String ReviewTitle = txtReviewTitle.Text;
        String Rating = txtRating.Text;
        String DateSubmitted = txtDateSubmitted.Text;
        String IsApproved = chkIsApproved.Text;

        String Error = "";
        Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, Rating, DateSubmitted);

        if (Error == "")
        {
            //captures
            AnReview.ReviewId = ReviewId;
            AnReview.CustomerName = CustomerName;
            AnReview.ReviewDescription = ReviewDescription;
            AnReview.ReviewTitle = ReviewTitle;
            AnReview.Rating = Convert.ToInt32(Rating);
            AnReview.DateSubmitted = Convert.ToDateTime(DateSubmitted);
            AnReview.IsApproved = chkIsApproved.Checked;
            
            clsReviewCollection ReviewList = new clsReviewCollection();
            if (ReviewId == -1)
            {
                ReviewList.ThisReview = AnReview;
                ReviewList.Add();
            }
            else
            {
                ReviewList.ThisReview.Find(ReviewId);
                ReviewList.ThisReview = AnReview;
                ReviewList.Update();
            }
            Response.Redirect("ReviewsList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsReview AnReview = new clsReview();
        Int32 ReviewId;
        Boolean Found = false;
        ReviewId = Convert.ToInt32(txtReviewId.Text);
        Found = AnReview.Find(ReviewId);
        if (Found == true)
        {
            txtCustomerName.Text = AnReview.CustomerName;
            txtRating.Text = AnReview.Rating.ToString();
            txtDateSubmitted.Text = AnReview.DateSubmitted.ToString();
            txtReviewDescription.Text = AnReview.ReviewDescription;
            txtReviewTitle.Text = AnReview.ReviewTitle;
            chkIsApproved.Checked = AnReview.IsApproved;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}