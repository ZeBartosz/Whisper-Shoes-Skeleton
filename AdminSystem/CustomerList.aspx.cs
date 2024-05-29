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
        //if this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "Customer_id";
        lstCustomerList.DataTextField = "Customer_Last_Name";
        lstCustomerList.DataBind();
    }



    protected void BtnAdd_Click1(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Customer_id"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }
}