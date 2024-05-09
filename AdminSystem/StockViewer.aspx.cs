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
        //creates a new instace of clsStock
        clsStock aStock = new clsStock();
        //get the data from the session object 
        aStock = (clsStock)Session["aStock"];
        //display the data 
        Response.Write(aStock.stockName);
        Response.Write("<br/>");
        Response.Write(aStock.stockDescription);
        Response.Write("<br/>");
        Response.Write(aStock.stockQuantity);
        Response.Write("<br/>");
        Response.Write(aStock.stockRestockThreshold);
        Response.Write("<br/>");
        Response.Write(aStock.stockLastRestocked);
        Response.Write("<br/>");
        Response.Write(aStock.stockAutoRestock);

    }
}