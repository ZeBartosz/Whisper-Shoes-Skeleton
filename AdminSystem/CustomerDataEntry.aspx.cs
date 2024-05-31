using System;
using System.Activities.Expressions;
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
        int Customer_id = Convert.ToInt32(txtCustomer_id.Text);
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
            ACustomer.Customer_id =  Customer_id;
            ACustomer.Customer_First_Name = Customer_First_Name;
            ACustomer.Customer_Last_Name = Customer_Last_Name;
            ACustomer.Customer_DOB = Convert.ToDateTime(Customer_DOB);
            ACustomer.Customer_Address = Customer_Address;
            ACustomer.Customer_Phone_Nmbr = Customer_Phone_Nmbr;
            ACustomer.Save_Payment_Info = ChkSavePaymentInfo.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (Customer_id == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(Customer_id);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
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

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        int Customer_id = Convert.ToInt32(txtCustomer_id.Text);
        Customer.ThisCustomer.Find(Customer_id);
        txtCustomer_id.Text = Customer.ThisCustomer.Customer_id.ToString();
        txtCustomerFirstName.Text = Customer.ThisCustomer.Customer_First_Name.ToString();
        txtCustomerLastName.Text = Customer.ThisCustomer.Customer_Last_Name.ToString();
        txtCustomerAddress.Text = Customer.ThisCustomer.Customer_Address.ToString();
        txtCustomerDOB.Text = Customer.ThisCustomer.Customer_DOB.ToString();
        txtCustomerPhoneNmbr.Text = Customer.ThisCustomer.Customer_Phone_Nmbr.ToString();
        ChkSavePaymentInfo.Checked = Customer.ThisCustomer.Save_Payment_Info;

    }
    
}