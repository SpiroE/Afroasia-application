using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display current data for the record
                DisplayStaff();
            }
        }

    }

    void DisplayStaff()
    {
        //create a new instance of staff
        clsStaffCollection Staff = new clsStaffCollection();
        //find record to update
        Staff.ThisStaff.Find(StaffID);
        //display data for this record
        txtStaffID.Text = Staff.ThisStaff.StaffID.ToString();
        txtStaffName.Text = Staff.ThisStaff.StaffName.ToString();
        txtStaffPhoneNo.Text = Staff.ThisStaff.StaffPhoneNo.ToString();
        txtStaffPayroll.Text = Staff.ThisStaff.StaffPayroll.ToString();
        txtSchedule.Text = Staff.ThisStaff.Schedule.ToString();
        txtAttendance.Text = Staff.ThisStaff.Attendance.ToString();
        chkShiftConfirmation.Checked = Staff.ThisStaff.ShiftConfirmation;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        string StaffName = txtStaffName.Text;
        //capture the staff phone no
        string StaffPhoneNo = txtStaffPhoneNo.Text;
        //capture the staff payroll
        string StaffPayroll = txtStaffPayroll.Text;
        //capture the schedule
        string Schedule = txtSchedule.Text;
        //capture the attendance
        string Attendance = txtAttendance.Text;
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffName, StaffPhoneNo, StaffPayroll, Schedule, Attendance);
        if (Error == "")
        {
            //captures the staff id
            AStaff.StaffID = StaffID;
            //captures the staff name
            AStaff.StaffName = StaffName;
            //captures staff phone no
            AStaff.StaffPhoneNo = StaffPhoneNo;
            //captures staff payroll
            AStaff.StaffPayroll = StaffPayroll;
            //captures schedule
            AStaff.Schedule = Schedule;
            //captures attendance
            AStaff.Attendance = Convert.ToDateTime(Attendance);
            //captures shift confrimation
            AStaff.ShiftConfirmation = chkShiftConfirmation.Checked;
            //create new instance of staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record (StaffID = -1) then add the data
            if (StaffID == -1)
            {
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add new record
                StaffList.Add();
            }
            //otherwise it must be an updated
            else
            {
                //find record to update
                StaffList.ThisStaff.Find(StaffID);
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update record
                StaffList.Update();
            }
            //redirect to listpage
            Response.Redirect("5~StaffList.aspx");

        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //variable that stores primary key
        Int32 StaffID;
        //variable that stores result of find method
        Boolean Found = false;
        //get the primary key the user entered
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            //displays every value of each property inside the form
            txtStaffID.Text = AStaff.StaffID.ToString();
            txtStaffName.Text = AStaff.StaffName;
            txtStaffPhoneNo.Text = AStaff.StaffPhoneNo;
            txtStaffPayroll.Text = AStaff.StaffPayroll;
            txtSchedule.Text = AStaff.Schedule;
            txtAttendance.Text = AStaff.Attendance.ToString();
            chkShiftConfirmation.Checked = AStaff.ShiftConfirmation;
        }
    }
}