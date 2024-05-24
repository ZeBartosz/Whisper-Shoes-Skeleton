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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 stockId;
        // if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            stockId = Convert.ToInt32(lstStockList.SelectedValue);
            // store the data in the session object
            Session["stockId"] = stockId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to sore the primary key
        Int32 stockId;
        // if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            // get the primary key value of the record delete
            stockId = Convert.ToInt32(lstStockList.SelectedValue);
            // store the data on the session object
            Session["stockId"] = stockId;
            // redirect to the delete page
            Response.Redirect("stockConfirmDelete.aspx");
            
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the address object
        clsStockCollection allStock = new clsStockCollection();
        // retrieve the value of post code from the presenttion laye
        allStock.ReportByStockName(txtFilterStockName.Text);
        // set the data source to the list of addresses in the collection
        lstStockList.DataSource = allStock.StockList;
        // set the name of the primar key 
        lstStockList.DataValueField = "stockId";
        // set the name of the field to display
        lstStockList.DataTextField = "stockName";
        // bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an instance of the address object
        clsStockCollection allStock = new clsStockCollection();
        // set an empty string
        allStock.ReportByStockName("");
        // clear any exisiting filter to tidy up the interface
        txtFilterStockName.Text = "";
        // set the data source to the list of addresses in the collectin
        lstStockList.DataSource = allStock.StockList;
        // set the name of the primar key 
        lstStockList.DataValueField = "stockId";
        // set the name of the field to display
        lstStockList.DataTextField = "stockName";
        // bind the data to the list
        lstStockList.DataBind();
    }
}