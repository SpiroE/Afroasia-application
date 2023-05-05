using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session oject to indicate new record
        Session["IssueID"] = -1;
        //redirect to data entry page
        Response.Redirect("CustomerServiceDataEntry.aspx");
    }

    void DisplayCustomerService()
    {
        //Create an instance of the CustomerService collection
        clsCustomerServiceCollection CustomerService = new clsCustomerServiceCollection();
        //Set the data source to the CustomerService list in the collection
        lstCustomerServiceList.DataSource = CustomerService.CustomerServiceList;
        //Set the name of the primary key
        lstCustomerServiceList.DataValueField = "IssueID";
        //Set the data field to display
        lstCustomerServiceList.DataTextField = "Issue";
        //Bind the data to the list
        lstCustomerServiceList.DataBind();
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key of the record we want to edit
        Int32 IssueID;
        //If a record has been selected on the list
        if (lstCustomerServiceList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            IssueID = Convert.ToInt32(lstCustomerServiceList.SelectedValue);
            //Store the data in the session object
            Session["IssueID"] = IssueID;
            //Redirect to the edit page
            Response.Redirect("CustomerServiceDataEntry.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //Variable to store the primary key of the record we want to edit
        Int32 IssueID;
        //If a record has been selected on the list
        if (lstCustomerServiceList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            IssueID = Convert.ToInt32(lstCustomerServiceList.SelectedValue);
            //Store the data in the session object
            Session["IssueID"] = IssueID;
            //Redirect to the edit page
            Response.Redirect("3~CustomerServiceDataEntry.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        
    }
}
