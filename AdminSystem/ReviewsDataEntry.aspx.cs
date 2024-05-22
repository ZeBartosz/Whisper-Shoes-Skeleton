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
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnOK_Click1(object sender, EventArgs e)
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
        Error = AnReview.Valid(CustomerName, ReviewDescription, ReviewTitle, Rating, IsApproved);

        if (Error == "")
        {
            //captures
            AnReview.CustomerName = CustomerName;
            AnReview.ReviewDescription = ReviewDescription;
            AnReview.ReviewTitle = ReviewTitle;
            AnReview.Rating = Rating
            AnReview.DateSubmitted = Convert.ToDateTime(DateSubmitted);
            Session["AnReview"] = AnReview;
            //navigate to the viewer
            Response.Redirect("ReviewBookViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsReview AnReview = new clsReview();
        Int32 ReviewId;
        Boolean Found = false;
        ReviewId = Convert.ToInt32(txtReviewID.Text);
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
}