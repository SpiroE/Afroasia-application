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
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        //captures the staff name
        AStaff.StaffName = txtStaffName.Text;
        //captures staff phone no
        AStaff.StaffPhoneNo = txtStaffPhoneNo.Text;
        //captures payroll
        AStaff.StaffPayroll = txtPayroll.Text;
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
}