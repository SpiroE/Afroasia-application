using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //then update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set data source to the list of staff within the collection
        lstStaffList.DataSource = Staff.StaffList;
        //setting the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //setting the data field to be displayed
        lstStaffList.DataTextField = "StaffName";
        //bind data to the list
        lstStaffList.DataBind();
    }
}