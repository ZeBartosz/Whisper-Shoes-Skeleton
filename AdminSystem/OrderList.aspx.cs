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
        if (IsPostBack == false)
        {
            DisplayOrder();
        }

    }
    void DisplayOrder()
    {
        clsOrderCollection order = new clsOrderCollection();
        lstOrderList.DataSource = order.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "For Edit, Select Record.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "For Delete, Select Record.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        AOrder.ReportByShippingAddress(txtShippingAddress.Text);
        lstOrderList.DataSource = AOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        AOrder.ReportByShippingAddress("");
        txtShippingAddress.Text = "";
        lstOrderList.DataSource = AOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}