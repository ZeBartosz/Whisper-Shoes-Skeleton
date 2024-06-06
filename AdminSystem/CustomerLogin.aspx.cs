using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsCustomersUser AUser = new clsCustomersUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AUser.FindUser(UserName, Password);
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("CustomerList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "log in details are incorrect";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}