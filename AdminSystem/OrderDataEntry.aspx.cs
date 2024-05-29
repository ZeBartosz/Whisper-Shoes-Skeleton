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

    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        string CustomerId = txtCustomerId.Text;
        string ItemId = txtItemId.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Active = chkActive.Text;
        string Error = "";
        Error = Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, ShippingAddress, TotalAmount);
        if (Error == "")
        {
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.ItemId = Convert.ToInt32(ItemId);
            AnOrder.ShippingAddress = txtShippingAddress.Text;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = (float)Convert.ToDecimal(TotalAmount);
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if(Found == true)
        {
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            txtItemId.Text = AnOrder.ItemId.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress.ToString();
            txtOrderCompleted.Text = AnOrder.OrderCompleted.ToString();
        }
    }
}