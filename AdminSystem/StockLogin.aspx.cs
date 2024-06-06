using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // create an instance of the stock user class
        clsStockUser anUser = new clsStockUser();
        // create the variables to store the data
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        // create a variable to store the result of the find user operation
        Boolean Found = false;
        // get the username and password entered by the user
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        // find the record
        Found = anUser.FindUser(UserName, Password);
        // add a session to capture the user name
        Session["anUser"] = anUser;
        // if username and/or password is empty
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username : ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password : ";
        }
        // if find
        else if (Found == true)
        {
            // redirect to the list page 
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            // record the error 
            lblError.Text = "Login details are incorrect. Please Try again "; 
        }

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}