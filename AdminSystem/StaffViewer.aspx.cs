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
        Staff = (clsStaff)Session["StaffName"];
        //display the staff name
        Response.Write(Staff.StaffName);

        Staff = (clsStaff)Session["StaffEmail"];
        Response.Write(Staff.StaffEmail);

        Staff = (clsStaff)Session["StaffPassword"];
        Response.Write(Staff.StaffPassword);

        Staff = (clsStaff)Session["StaffStartDate"];
        Response.Write(Staff.StaffStartDate);

        Staff = (clsStaff)Session["StaffSalary"];
        Response.Write(Staff.StaffSalary);

        Staff = (clsStaff)Session["StaffManager"];
        Response.Write(Staff.ManagerActive);

    }
}