using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        //constructor for the class
        public clsStaffCollection()
        {
            // Variable for Index
            Int32 Index = 0;
            // Variable to store Record Count
            Int32 RecordCount = 0;
            // Object for SQL Data Connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure tblCustomer_SelectAll
            DB.Execute("sproc_tblStaff_SelectAll");
            // Gets the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a fresh blank staff
                clsStaff AStaff = new clsStaff();
                //read in fields from the current record
                AStaff.ShiftConfirmation = Convert.ToBoolean(DB.DataTable.Rows[Index]["ShiftConfirmation"]);
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNo"]);
                AStaff.StaffPayroll = Convert.ToString(DB.DataTable.Rows[Index]["StaffPayroll"]);
                AStaff.Schedule = Convert.ToString(DB.DataTable.Rows[Index]["Schedule"]);
                AStaff.Attendance = Convert.ToDateTime(DB.DataTable.Rows[Index]["Attendance"]);
                //add record to the private data member
                mStaffList.Add(AStaff);
                //point to the next record
                Index++;
            }
        }

        public List<clsStaff> StaffList 
        {
            get
            {
                //return private data
                return mStaffList;
            }
            set
            {
                //set private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set 
            {
                //return to this later
            }
        }

        public clsStaff ThisStaff 
        {
            get
            {
                //return private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffPayroll", mThisStaff.StaffPayroll);
            DB.AddParameter("@Schedule", mThisStaff.Schedule);
            DB.AddParameter("@Attendance", mThisStaff.Attendance);
            DB.AddParameter("@ShiftConfirmation", mThisStaff.ShiftConfirmation);
            //execute query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffPhoneNo", mThisStaff.StaffPhoneNo);
            DB.AddParameter("@StaffPayroll", mThisStaff.StaffPayroll);
            DB.AddParameter("@Schedule", mThisStaff.Schedule);
            DB.AddParameter("@Attendance", mThisStaff.Attendance);
            DB.AddParameter("@ShiftConfirmation", mThisStaff.ShiftConfirmation);
            //execute stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}