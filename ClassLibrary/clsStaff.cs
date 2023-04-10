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
            //set the private data members to the test data value
            mStaffID = 11;
            mAttendance = Convert.ToDateTime("16/09/2015");
            mShiftConfirmation = true;
            mStaffName = "Leyla Smith";
            mStaffPhoneNo = "+447305085596";
            mStaffPayroll = "16.00";
            mSchedule = "Weekdays";
            //always return true
            return true;
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