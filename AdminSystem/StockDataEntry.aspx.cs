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



    protected void btnAdd_Click(object sender, EventArgs e)
    {    
        //create a new instance of clsStock
        clsStock aStock = new clsStock();
        //captures the stock name
        aStock.stockName = txtStockName.Text;
        aStock.stockDescription = txtStockDescription.Text;
        aStock.stockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        aStock.stockRestockThreshold = Convert.ToInt32(txtStockRestockThreshold.Text);
        aStock.stockLastRestocked = Convert.ToDateTime(DateTime.Now);
        aStock.stockAutoRestock = chkStockAutoRestock.Checked;

        //stores the name in the session object
        Session["aStock"] = aStock;
        //navigate to the viewer
        Response.Redirect("StockViewer.aspx");       
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