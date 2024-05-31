using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with the page level scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current date 
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        clsStaffCollection AllStaff = new clsStaffCollection();
        AllStaff.ThisStaff.Find(StaffId);
        txtStaffId.Text = AllStaff.ThisStaff.StaffId.ToString();
        txtStaffName.Text = AllStaff.ThisStaff.StaffName.ToString();
        txtStaffEmail.Text = AllStaff.ThisStaff.StaffEmail.ToString();
        txtStaffPassword.Text = AllStaff.ThisStaff.StaffPassword.ToString();
        txtStaffStartDate.Text = AllStaff.ThisStaff.StaffStartDate.ToString();
        txtStaffSalary.Text = AllStaff.ThisStaff.StaffSalary.ToString();
        chkStaffManager.Checked = AllStaff.ThisStaff.StaffManager;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance
        clsStaff Staff = new clsStaff();
        //capture data
        string StaffName = txtStaffName.Text;
        string StaffEmail = txtStaffEmail.Text;
        string StaffPassword = txtStaffPassword.Text;
        string StaffStartDate = txtStaffStartDate.Text;
        string StaffSalary = txtStaffSalary.Text;
        string StaffManager = chkStaffManager.Text;
        //varoable to store error messages
        string Error = "";
        //validate the data 
        Error = Staff.Valid(StaffName, StaffEmail, StaffPassword, StaffStartDate);
        if (Error == "")
        {
            //capture data
            Staff.StaffId = StaffId;
            Staff.StaffName = StaffName;
            Staff.StaffEmail = StaffEmail;
            Staff.StaffPassword = StaffPassword;
            Staff.StaffStartDate = Convert.ToDateTime(StaffStartDate);
            Staff.StaffSalary = Convert.ToInt32(StaffSalary);
            Staff.StaffManager = chkStaffManager.Checked;
            //create new instance
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record then add the data
            if (StaffId == -1)
            {
                StaffList.ThisStaff = Staff;
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = Staff;
                StaffList.Update();
            }
            //redirect
            Response.Redirect("StaffList.aspx");
            
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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