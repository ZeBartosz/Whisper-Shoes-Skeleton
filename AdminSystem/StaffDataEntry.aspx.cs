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
        Staff.StaffManager = chkStaffManager.Checked;

        //store the name in a session object
        Session["Staff"] = Staff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff Staff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = Staff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffName.Text = Staff.StaffName;
            txtStaffEmail.Text = Staff.StaffEmail;
            txtStaffPassword.Text = Staff.StaffPassword;
            txtStaffStartDate.Text = Staff.StaffStartDate.ToString();
            txtStaffSalary.Text = Staff.StaffSalary.ToString();
            chkStaffManager.Checked = Staff.StaffManager;

        }

    }
}