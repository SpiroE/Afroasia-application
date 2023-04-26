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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate a new record
        Session["StaffID"] = -1;
        //redirect to data entry page
        Response.Redirect("5~StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to Edit page
            Response.Redirect("5~StaffDataEntry.aspx");
        }
        //if no record has been selected then output error text
        else
        {
            lblError.Text = "You need to select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to Edit page
            Response.Redirect("5~StaffConfirmDelete.aspx");
        }
        //if no record has been selected then output error text
        else
        {
            lblError.Text = "You need to select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create a new instance of staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName(txtFilter.Text);
        lstStaffList.DataSource = Staffs.StaffList;
        //set name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create a new instance of staff collection
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName("");
        //clear any existing filters to keep interface tidy
        txtFilter.Text = "";
        lstStaffList.DataSource = Staffs.StaffList;
        //set name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind data to the list
        lstStaffList.DataBind();
    }
}