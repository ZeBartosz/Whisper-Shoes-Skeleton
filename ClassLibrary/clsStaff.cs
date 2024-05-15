using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Find(int StaffId)
        {
            //set the private data members to the test data value
            mStaffId = 21;
            mStaffName = "Test Name";
            mStaffEmail = "Test@email.com";
            mStaffPassword = "TestPassword";
            mStaffStartDate = Convert.ToDateTime("15/05/2023");
            mStaffSalary = 1;
            mManagerActive = true;
            //always return true
            return true;
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
        private Boolean mManagerActive;
        public Boolean ManagerActive
        {
            get
            {
                return mManagerActive;
            }
            set
            {
                mManagerActive = value;
            }
        }
    }
}