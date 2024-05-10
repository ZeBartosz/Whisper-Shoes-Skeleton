using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //navigate to the view page
        Response.Redirect("ReviewViewer.aspx");

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsReview
        clsReview AnReview = new clsReview();
        //capture the CustomerName
        AnReview.CustomerName = txtCustomerName.Text;
        //store the review in the session object
        Session["AnReview"] = AnReview;
        //navigate to the view page
        Response.Redirect("ReviewsViewer.aspx");
      
    }

        protected void txtReviewTitle_TextChanged(object sender, EventArgs e)
    {

    }
}