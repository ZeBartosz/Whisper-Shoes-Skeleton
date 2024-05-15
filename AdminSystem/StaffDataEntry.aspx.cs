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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance
        clsStaff Staff = new clsStaff();
        //capture the name
        Staff.StaffName = txtStaffName.Text;
        Staff.StaffEmail = txtStaffEmail.Text;
        Staff.StaffPassword = txtStaffPassword.Text;
        Staff.StaffStartDate = Convert.ToDateTime(txtStaffStartDate.Text);
        Staff.StaffSalary = Convert.ToInt32(txtStaffSalary.Text);
        Staff.ManagerActive = chkStaffManager.Checked;

        //store the name in a session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx"); 
    }

    protected void txtStaffPassword_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}