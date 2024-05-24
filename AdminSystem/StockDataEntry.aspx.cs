using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 stockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the stock to be processed
        stockId = Convert.ToInt32(Session["stockId"]);
        if (IsPostBack == false)
        {
            // if this is the not a new record
            if (stockId != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        // create an instance of the address book
        clsStockCollection allStock = new clsStockCollection();
        // find the record to update
        allStock.ThisStock.Find(stockId);
        // display the data for the record
        txtStockId.Text = allStock.ThisStock.stockId.ToString();
        txtStockName.Text = allStock.ThisStock.stockName.ToString();
        txtStockDescription.Text = allStock.ThisStock.stockDescription.ToString();
        txtStockQuantity.Text = allStock.ThisStock.stockQuantity.ToString();
        txtStockRestockThreshold.Text = allStock.ThisStock.stockRestockThreshold.ToString();
        txtStockLastRestocked.Text = allStock.ThisStock.stockLastRestocked.ToString();
        chkStockAutoRestock.Checked = allStock.ThisStock.stockAutoRestock;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStock
        clsStock aStock = new clsStock();
        // captures the stock name
        String Name = txtStockName.Text;
        String Description = txtStockDescription.Text;
        String Quantity = txtStockQuantity.Text;
        String RestockThreshold = txtStockRestockThreshold.Text;
        String LastRestocked = txtStockLastRestocked.Text;
        String stockAutoRestock = chkStockAutoRestock.Text;

        String Error = "";
        Error = aStock.Valid(Name, Description, Quantity, RestockThreshold, LastRestocked);

        if (Error == "")
        {
            // captures the stock name
            aStock.stockId = stockId;
            aStock.stockName = Name;
            aStock.stockDescription = Description;
            aStock.stockQuantity = Convert.ToInt32(Quantity);
            aStock.stockRestockThreshold = Convert.ToInt32(RestockThreshold);
            aStock.stockLastRestocked = Convert.ToDateTime(LastRestocked);
            aStock.stockAutoRestock = chkStockAutoRestock.Checked;
            // create a new instance of the address collection
            clsStockCollection allStock = new clsStockCollection();
            // if this is a new record 
            if (stockId == -1)
            {
                // set the ThisStock property
                allStock.ThisStock = aStock;
                // add the new record
                allStock.Add();
            }
            // otherwise it must be an update
            else
            {
                // find the record to update
                allStock.ThisStock.Find(stockId);
                // set the ThisStock property
                allStock.ThisStock = aStock;
                // update the record
                allStock.Update();
            }

            // navigate to the viewer
            Response.Redirect("StockList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();
        Int32 stockId;
        Boolean Found = false;
        stockId = Convert.ToInt32(txtStockId.Text);
        Found = aStock.Find(stockId);
        if (Found == true)
        {
            txtStockName.Text = aStock.stockName;
            txtStockDescription.Text = aStock.stockDescription;
            txtStockQuantity.Text = aStock.stockQuantity.ToString();
            txtStockRestockThreshold.Text = aStock.stockRestockThreshold.ToString();
            txtStockLastRestocked.Text = aStock.stockLastRestocked.ToString();
            chkStockAutoRestock.Checked = aStock.stockAutoRestock;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}