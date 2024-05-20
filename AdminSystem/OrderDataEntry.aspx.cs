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
        //capture the Shipping Address
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
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