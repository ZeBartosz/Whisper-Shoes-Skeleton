using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYES_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ThisOrder.Find(OrderId);
        AllOrders.Delete();
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}