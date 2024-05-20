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
            DisplayStaff();
        }

    }

    void DisplayStaff()
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
}