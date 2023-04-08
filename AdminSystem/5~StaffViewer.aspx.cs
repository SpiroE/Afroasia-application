using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsstaff
        clsStaff AStaff = new clsStaff();
        //get data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff id for this entry

        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.StaffName);
        Response.Write(AStaff.StaffPhoneNo);
        Response.Write(AStaff.StaffPayroll);
        Response.Write(AStaff.Schedule);
        Response.Write(AStaff.Attendance);
        Response.Write(AStaff.ShiftConfirmation);
    }
}