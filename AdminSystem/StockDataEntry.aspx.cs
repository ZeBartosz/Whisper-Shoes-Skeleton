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
    protected void Page_Load(object sender, EventArgs e)
    {
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
            aStock.stockName = Name;
            aStock.stockDescription = Description;
            aStock.stockQuantity = Convert.ToInt32(Quantity);
            aStock.stockRestockThreshold = Convert.ToInt32(RestockThreshold);
            aStock.stockLastRestocked = Convert.ToDateTime(LastRestocked);
            aStock.stockAutoRestock = chkStockAutoRestock.Checked;
            // create a new instance of the address collection
            clsStockCollection allStock = new clsStockCollection();
            // set the ThisStock property 
            allStock.ThisStock = aStock;
            //add the new record
            allStock.Add();
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
}