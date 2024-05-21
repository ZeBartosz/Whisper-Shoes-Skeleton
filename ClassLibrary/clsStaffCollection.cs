using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sporc_tbStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff Staff = new clsStaff();
                //read in the fields for the current record
                Staff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                Staff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                Staff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                Staff.StaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                Staff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                Staff.StaffManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffManager"]);
                //add record to private data member
                mStaffList.Add(Staff);
                //point at next record
                Index++;


            }

        }

        public List<clsStaff> StaffList
        {
            get 
            {
                return mStaffList; 
            }
            set 
            { 
                mStaffList = value; 
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value; 
            }
        }

        public int Add()
        {
            //adds a record to the database based on values of mThisStaff
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffStartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffManager", mThisStaff.StaffManager);
            //execute the query
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}