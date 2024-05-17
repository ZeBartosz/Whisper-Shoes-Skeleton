using System;

    public class clsStaff
{
    public bool Find(int StaffId)
    {
        //create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        //add the parameter for the staff id search for
        DB.AddParameter("@StaffId", StaffId);
        //execute the stored procedure
        DB.Execute("sproc_tblStaff_FilterByStaffId");
        //if one record is found (there should be either 1 or zero)
        if (DB.Count == 1)
        {
            //copy the data from the database to the private data members
            mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
            mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
            mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
            mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
            mStaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStartDate"]);
            mStaffSalary = Convert.ToInt32(DB.DataTable.Rows[0]["StaffSalary"]);
            mStaffManager = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffManager"]);
            //return that everything worked
            return true;
        }
        //if no record was found
        else
        {
            //return false indicating problem
            return false;
        }

    }
    //private data member for the staff id property
    private Int32 mStaffId;

    public Int32 StaffId
    {
        get
        {
            return mStaffId;
        }
        set
        {
            mStaffId = value;
        }
    }

    private String mStaffName;

    public String StaffName
    {
        get
        {
            return mStaffName;
        }
        set
        {
            mStaffName = value;
        }
    }

    private String mStaffEmail;

    public String StaffEmail
    {
        get
        {
            return mStaffEmail;
        }
        set
        {
            mStaffEmail = value;
        }
    }

    private String mStaffPassword;
    public String StaffPassword
    {
        get
        {
            return mStaffPassword;
        }
        set
        {
            mStaffPassword = value;
        }
    }
    private DateTime mStaffStartDate;
    public DateTime StaffStartDate
    {
        get
        {
            return mStaffStartDate;
        }
        set
        {
            mStaffStartDate = value;
        }
    }
    private float mStaffSalary;
    public float StaffSalary
    {
        get
        {
            return mStaffSalary;
        }
        set
        {
            mStaffSalary = value;
        }
    }
    private Boolean mStaffManager;
    public Boolean StaffManager
    {
        get
        {
            return mStaffManager;
        }
        set
        {
            mStaffManager = value;
        }
    }
}
