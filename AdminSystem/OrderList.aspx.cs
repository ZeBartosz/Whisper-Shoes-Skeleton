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
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "ShippingAddress";
        lstOrderList.DataBind();
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}