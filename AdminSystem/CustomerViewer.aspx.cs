using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomers
        clsCustomers ACustomer = new clsCustomers();
        //get the data from the session object
        ACustomer = (clsCustomers)Session["ACustomer"];
        //display the customers first name for this entry
        Response.Write(ACustomer.Customer_First_Name);
        Response.Write(ACustomer.Customer_Last_Name);
        Response.Write(ACustomer.Customer_DOB);
        Response.Write(ACustomer.Customer_Phone_Nmbr);
        Response.Write(ACustomer.Customer_Address);
        Response.Write(ACustomer.Save_Payment_Info);

    }
}