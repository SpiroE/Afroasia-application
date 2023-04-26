using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store primary key value of record
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the staff id to be deleted
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff class
        clsStaffCollection Staff = new clsStaffCollection();
        //find record to delete
        Staff.ThisStaff.Find(StaffID);
        //delete record
        Staff.Delete();
        //redirect to main page
        Response.Redirect("5~StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("5~StaffList.aspx");
    }
}