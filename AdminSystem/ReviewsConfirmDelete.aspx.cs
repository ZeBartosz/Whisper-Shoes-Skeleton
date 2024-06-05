using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ReviewId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ReviewId = Convert.ToInt32(Session["ReviewId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsReviewCollection ReviewBook = new clsReviewCollection();
        ReviewBook.ThisReview.Find(ReviewId);
        ReviewBook.Delete();
        Response.Redirect("ReviewsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewsList.aspx");
    }
}