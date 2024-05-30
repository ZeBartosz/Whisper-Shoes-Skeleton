using System;

namespace ClassLibrary
{
    public class clsOrderUser
{

        private int mUserId;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserId
        {
            get { return mUserId; }
            set { mUserId = value; }
        }
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get { return mDepartment; }
                        set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}