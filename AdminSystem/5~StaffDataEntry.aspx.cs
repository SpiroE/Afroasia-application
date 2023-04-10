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
        //captures the staff id
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        //captures the staff name
        AStaff.StaffName = txtStaffName.Text;
        //captures staff phone no
        AStaff.StaffPhoneNo = txtStaffPhoneNo.Text;
        //captures staff payroll
        AStaff.StaffPayroll = txtStaffPayroll.Text;
        //captures schedule
        AStaff.Schedule = txtSchedule.Text;
        //captures attendance
        AStaff.Attendance = Convert.ToDateTime(txtAttendance.Text);
        //captures shift confirmation
        AStaff.ShiftConfirmation = Convert.ToBoolean(chkShiftConfirmation.Checked);
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewrer page
        Response.Redirect("5~StaffViewer.aspx");
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