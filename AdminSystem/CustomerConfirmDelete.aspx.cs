using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 Customer_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Customer_id = Convert.ToInt32(Session["Customer_id"]);

    }

    protected void btnConfirmDeleteYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(Customer_id);
        Customer.Delete();
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnConfirmDeleteNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}