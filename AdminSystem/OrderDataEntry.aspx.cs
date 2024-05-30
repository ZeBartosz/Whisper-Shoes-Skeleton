using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
        }
    }
    void DisplayOrder()
    {
        clsOrderCollection OrdersAll = new clsOrderCollection();
        OrdersAll.ThisOrder.Find(OrderId);

        txtOrderId.Text = OrdersAll.ThisOrder.OrderId.ToString();
        txtCustomerId.Text = OrdersAll.ThisOrder.CustomerId.ToString();
        txtItemId.Text = OrdersAll.ThisOrder.ItemId.ToString();
        txtOrderDate.Text = OrdersAll.ThisOrder.OrderDate.ToString();
        txtTotalAmount.Text = OrdersAll.ThisOrder.TotalAmount.ToString();
        txtShippingAddress.Text = OrdersAll.ThisOrder.ShippingAddress.ToString();
        chkOrderCompleted.Checked = OrdersAll.ThisOrder.OrderCompleted;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        string CustomerId = txtCustomerId.Text;
        string ItemId = txtItemId.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Active = chkOrderCompleted.Text;
        string Error = "";
        Error = Error = AnOrder.Valid(CustomerId, ItemId, OrderDate, ShippingAddress, TotalAmount);
        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.ItemId = Convert.ToInt32(ItemId);
            AnOrder.ShippingAddress = txtShippingAddress.Text;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = (float)Convert.ToDecimal(TotalAmount);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");

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
            chkOrderCompleted.Checked= AnOrder.OrderCompleted;
        }
    }
}