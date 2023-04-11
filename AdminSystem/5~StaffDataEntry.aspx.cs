using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


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
            //store the address in the session object
            Session["AStaff"] = AStaff;
            //navigate to the viewrer page
            Response.Redirect("5~StaffViewer.aspx");
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