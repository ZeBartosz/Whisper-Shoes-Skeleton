using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReviewLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsReviewUser AnUser = new clsReviewUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        if (txtUserName.Text == "")
        {
            lblError.Text = "Entre a Username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Entre a Password ";
        }
        else if (Found == true)
        {
            Response.Redirect("ReviewsList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}