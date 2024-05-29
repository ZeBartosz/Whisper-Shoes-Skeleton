using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        // private data
        private Int32 mUserId;
        private string mUserName;
        private string mUserPassword;
        private string mDepartment;

        public int UserId 
        { 
            get 
            { 
                return mUserId; 
            }
            set 
            { 
                mUserId = value; 
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set 
            { 
            mUserName = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return mUserPassword;
            }
            set 
            {
                mUserPassword = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set 
            { 
                mDepartment = value; 
            }
        }

        public bool FindUser(string userName, string password)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameters for the user
            DB.AddParameter("UserName", userName);
            DB.AddParameter("Password", password);
            // execute the procedure
            DB.Execute("sproc_tblUsers_FindUserNamePw");
            // if one record is found
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                // return true if everything is okay
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}