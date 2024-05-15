using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance
        clsStaff Staff = new clsStaff();
        //get the data from session
        Staff = (clsStaff)Session["Staff"];
        //display the data
        Response.Write(Staff.StaffName);
        Response.Write("<br/>");
        Response.Write(Staff.StaffEmail);
        Response.Write("<br/>");
        Response.Write(Staff.StaffPassword);
        Response.Write("<br/>");
        Response.Write(Staff.StaffStartDate);
        Response.Write("<br/>");
        Response.Write(Staff.StaffSalary);
        Response.Write("<br/>");
        Response.Write(Staff.ManagerActive);
        Response.Write("<br/>");



    }
}