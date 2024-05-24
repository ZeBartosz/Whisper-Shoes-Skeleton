using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 stockId;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be deleted from the session object
        stockId = Convert.ToInt32(Session["stockId"]);
    }



    protected void btnYes_Click(object sender, EventArgs e)
    {
        // creates a new instance of the stock collection class
        clsStockCollection allStock = new clsStockCollection();
        // find the record to delete
        allStock.ThisStock.Find(stockId);
        // delete the record 
        allStock.Delete();
        // redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // redirect back to the main page
        Response.Redirect("StockList.aspx");
    }
}