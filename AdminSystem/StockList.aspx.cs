using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayStocks();
        }

    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "stockId";
        lstStockList.DataTextField = "stockName";
        lstStockList.DataBind();
    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        // Store -1 the session object to indicate this is a new record
        Session["StockId"] = -1;
        // Redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }
}