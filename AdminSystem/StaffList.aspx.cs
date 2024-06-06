using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //display the list box
            DisplayAllStaff();
        }

        clsStaffUser anUser = new clsStaffUser();
        anUser = (clsStaffUser)Session["anUser"];
        Response.Write("Logged in as: " + anUser.UserName);

    }

    void DisplayAllStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list the staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data feild
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirecr to the data entry page 
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1 )
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection Staff = new clsStaffCollection();
        //retrieve the value of staff name from presentation layer 
        Staff.ReportByStaffName(txtFilter.Text);
        //set the data source to the list if addresses in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name pf primary key and name of field to display 
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        //bind data to list
        lstStaffList.DataBind();
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffName("");
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "StaffName";
        lstStaffList.DataBind();

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}