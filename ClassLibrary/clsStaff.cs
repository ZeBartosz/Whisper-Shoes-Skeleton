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
            if (DB.Count == 1 )
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

        public string Valid(string staffName, string staffEmail, string staffPassword, string staffStartDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;

            //if StaffName is blank
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "You must enter a name :";
            }
            //if StaffName is greater than 70 characters
            if (staffName.Length > 70)
            {
                //record the error
                Error = Error + "Your name must be less than 70 characters : ";
            }


            DateTime DateComp = DateTime.Now.Date;
            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            try
            {
                DateTemp = Convert.ToDateTime(staffStartDate);
                //check to see if the date is less than today's date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if date is greater than today's date
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be on the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //if StaffEmail is blank
            if (staffEmail.Length == 0)
            {
                //record the error
                Error = Error + "You must enter a email :";
            }
            //if StaffEmail is greater than 55 characters
            if (staffEmail.Length > 55)
            {
                //record the error
                Error = Error + "Your email must be less than 55 characters : ";
            }
            if (staffEmail.Length < 3)
            {
                Error = Error + "Your email must be more than 3 characters :" ;
            }

            //if StaffPassword is blank
            if (staffPassword.Length == 0)
            {
                //record the error
                Error = Error + "You must enter a password :";
            }
            //if StaffPassword is greater than 55 characters
            if (staffPassword.Length > 20)
            {
                //record the error
                Error = Error + "Your password must be less than 20 characters : ";
            }
            if (staffPassword.Length < 6)
            {
                Error = Error + "Your password must be more than 6 characters :";
            }


            return Error;

        }
        //private data member for the staff id property
        private Int32 mStaffId;


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
