using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsReview
        clsReview AnReview = new clsReview();
        //get the data from the session object
        AnReview = (clsReview)Session["AnReview"];
        //display the customer name for this entry
        Response.Write(AnReview.CustomerName);

    }

   }