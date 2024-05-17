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


    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsCustomers
        clsCustomers ACustomer = new clsCustomers();
        //get firstname
        ACustomer.Customer_First_Name = txtCustomerFirstName.Text;
        //get last name
        ACustomer.Customer_Last_Name = txtCustomerLastName.Text;
        //Get DOB
        ACustomer.Customer_DOB = Convert.ToDateTime(DateTime.Now);
        //Get Phone number
        ACustomer.Customer_Phone_Nmbr = txtCustomerPhoneNmbr.Text;
        //get Address
        ACustomer.Customer_Address = txtCustomerAddress.Text;
        //save payment info
        ACustomer.Save_Payment_Info = ChkSavePaymentInfo.Checked;
        //store the first name in session object
        Session["ACustomer"] = ACustomer;
        //navigate to view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomers ACustomer = new clsCustomers();
        //create a variable to store the primary key
        Int32 Customer_id;
        //Create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        Customer_id = Convert.ToInt32(txtCustomer_id.Text);
        //find the record
        Found = ACustomer.Find(Customer_id);
        //if found
        if(Found == true)
        {

            //display the values of the properties in the form
            txtCustomerFirstName.Text = ACustomer.Customer_First_Name;
            txtCustomerLastName.Text = ACustomer.Customer_Last_Name;
            txtCustomerAddress.Text = ACustomer.Customer_Address;
            txtCustomerDOB.Text = ACustomer.Customer_DOB.ToString();
            txtCustomerPhoneNmbr.Text = ACustomer.Customer_Phone_Nmbr;
            ChkSavePaymentInfo.Checked = ACustomer.Save_Payment_Info;


        }
    }
}