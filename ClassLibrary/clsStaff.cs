using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data members for each property
        private Int32 mStaffID;
        private DateTime mAttendance;
        private bool mShiftConfirmation;
        private string mStaffName;
        private string mStaffPhoneNo;
        private string mStaffPayroll;
        private string mSchedule;

        public bool Find(int StaffID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the staff id to search
            DB.AddParameter("@StaffID", StaffID);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found it should be one or zero
            if (DB.Count == 1)
            {
                //set the private data to the test datas value
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]); ;
                mAttendance = Convert.ToDateTime(DB.DataTable.Rows[0]["Attendance"]);
                mShiftConfirmation = Convert.ToBoolean(DB.DataTable.Rows[0]["ShiftConfirmation"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNo"]);
                mStaffPayroll = Convert.ToString(DB.DataTable.Rows[0]["StaffPayroll"]);
                mSchedule = Convert.ToString(DB.DataTable.Rows[0]["Schedule"]);
                //always return value true
                return true;
            }
            else
            {
                //return a false value if there is a issue
                return false;
            }
        }

        public int StaffID
        {
            get
            {
                //this line of code sens data out of staff id
                return mStaffID;
            }
            set
            {
                //this line of code allows data into staff id
                mStaffID = value;
            }
        }

        public DateTime Attendance
        {
            get
            {
                //this line of code sens data out of attendance
                return mAttendance;
            }
            set
            { 
                //this line of code allows data into attendance
                mAttendance = value;
            }
        }
        public bool ShiftConfirmation
        {
            get
            {
                //this line of code sens data out of attendance
                return mShiftConfirmation;
            }
            set
            {
                //this line of code allows data into attendance
                mShiftConfirmation = value;
            }
        }

        public string StaffName
        {
            get
            {
                //this line of code sens data out of attendance
                return mStaffName;
            }
            set
            {
                //this line of code allows data into attendance
                mStaffName = value;
            }
        }

        public string StaffPhoneNo
        {
            get
            {
                //this line of code sens data out of attendance
                return mStaffPhoneNo;
            }
            set
            {
                //this line of code allows data into attendance
                mStaffPhoneNo = value;
            }
        }

        public string StaffPayroll
        {
            get
            {
                //this line of code sens data out of attendance
                return mStaffPayroll;
            }
            set
            {
                //this line of code allows data into attendance
                mStaffPayroll = value;
            }
        }

        public string Schedule
        {
            get
            {
                //this line of code sens data out of attendance
                return mSchedule;
            }
            set
            {
                //this line of code allows data into attendance
                mSchedule = value;
            }
        }

    }
}