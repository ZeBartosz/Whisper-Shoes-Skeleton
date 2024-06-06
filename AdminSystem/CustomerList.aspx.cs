using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 Customer_id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Customer_id = Convert.ToInt32(Session["Customer_id]"]);
        //if this is the first time the page is displayed.
        if (IsPostBack == false)
        {
            if(Customer_id != -1)
            {
                DisplayCustomers();
            }
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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 Customer_id;

        if (lstCustomerList.SelectedIndex != -1)
        {
            Customer_id = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["Customer_id"] = Customer_id;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 Customer_id;

        if (lstCustomerList.SelectedIndex != -1)
        {
            Customer_id = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["Customer_id"] = Customer_id;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByCustomerLastName(txtFilterCustomerLastName.Text);
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "Customer_id";
        lstCustomerList.DataTextField = "Customer_Last_Name";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByCustomerLastName("");
        txtFilterCustomerLastName.Text = "";
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "Customer_id";
        lstCustomerList.DataTextField = "Customer_Last_Name";
        lstCustomerList.DataBind();
    }

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}