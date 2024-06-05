using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayReviews();
        }
        clsReviewUser AnUser = new clsReviewUser();
        AnUser = (clsReviewUser)Session["AnUser"];
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayReviews()
    {
        clsReviewCollection Reviews = new clsReviewCollection();
        lstReviewList.DataSource = Reviews.ReviewList;
        lstReviewList.DataValueField = "ReviewId";
        lstReviewList.DataTextField = "CustomerName";
        lstReviewList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ReviewId"] = -1;
        Response.Redirect("ReviewsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ReviewId;
        if (lstReviewList.SelectedIndex != -1)
        {
            ReviewId = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewId"] = ReviewId;
            Response.Redirect("ReviewsDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ReviewId;
        if (lstReviewList.SelectedIndex != -1)
        {
            ReviewId = Convert.ToInt32(lstReviewList.SelectedValue);
            Session["ReviewId"] = ReviewId;
            Response.Redirect("ReviewsConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsReviewCollection AnReview = new clsReviewCollection();
        AnReview.ReportByCustomerName(txtFilter.Text);
        lstReviewList.DataSource = AnReview.ReviewList;
        lstReviewList.DataValueField = "ReviewId";
        lstReviewList.DataTextField = "CustomerName";
        lstReviewList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsReviewCollection AnReview = new clsReviewCollection();
        AnReview.ReportByCustomerName("");
        txtFilter.Text = "";
        lstReviewList.DataSource = AnReview.ReviewList;
        lstReviewList.DataValueField = "ReviewId";
        lstReviewList.DataTextField = "CustomerName";
        lstReviewList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}