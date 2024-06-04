using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of user class
        clsStaffUser anUser = new clsStaffUser();
        //create the variables 
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text; 
        //create variable to store the result
        Boolean Found = false;
        //get the the entered data
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        //find the record
        Found = anUser.FindUser(UserName, Password);
        //if empty
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password ";
        }
        //if found
        else if (Found == true)
        {
            //redirect
            Response.Redirect("StaffList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}