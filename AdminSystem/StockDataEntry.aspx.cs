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
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        //captures the stock name
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
            //captures the stock name
            aStock.stockName = Name;
            aStock.stockDescription = Description;
            //stockQuantity = Convert.ToInt32(Quantity);
            //aStock.stockRestockThreshold = Convert.ToInt32(RestockThreshold);
            aStock.stockLastRestocked = Convert.ToDateTime(LastRestocked);
            //aStock.stockAutoRestock = chkStockAutoRestock.Checked;
            //stores the name in the session object
            Session["aStock"] = aStock;
            //navigate to the viewer
            Response.Redirect("StockViewer.aspx");

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