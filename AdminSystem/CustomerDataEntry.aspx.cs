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
        string Customer_First_Name = txtCustomerFirstName.Text;
        string Customer_Last_Name = txtCustomerLastName.Text;
        string Customer_DOB = txtCustomerDOB.Text;
        string Customer_Phone_Nmbr = txtCustomerPhoneNmbr.Text;
        string Customer_Address = txtCustomerAddress.Text;
        string Save_Payment_Info = ChkSavePaymentInfo.Text;
        string Error = "";
        Error = ACustomer.Valid(Customer_First_Name, Customer_Last_Name, Customer_DOB, Customer_Address, Customer_Phone_Nmbr);
        if (Error == "")
        {
            ACustomer.Customer_First_Name = Customer_First_Name;
            ACustomer.Customer_Last_Name = Customer_Last_Name;
            ACustomer.Customer_DOB = Convert.ToDateTime(DateTime.Now);
            ACustomer.Customer_Phone_Nmbr = Customer_Phone_Nmbr;
            ACustomer.Customer_Address = Customer_Address;
            ACustomer.Save_Payment_Info = ChkSavePaymentInfo.Checked;
            //clsCustomerCollection CustomerList = new clsCustomerCollection();
            //CustomerList.ThisCustomer = ACustomer;
            //CustomerList.Add();

            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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