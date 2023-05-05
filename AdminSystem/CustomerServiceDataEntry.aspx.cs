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
        //create a new instance of clsCustomerService
        clsCustomerService ACustomerService = new clsCustomerService();
        //capture the CustomerID
        ACustomerService.CustomerID = Convert.ToInt32( txtCustomerID.Text.ToString());
        //store the Customer in the sesssion object
        Session["ACustomerService"] = ACustomerService;
        //navigate to the viewer page
        Response.Redirect("CustomerServiceViewer.aspx");
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {

        //create a new instance of clsCustomerService
        clsCustomerService ACustomerService = new clsCustomerService();
        //Capture the attributes
        string CustomerID = txtCustomerID.Text;
        string ProductID = txtProductID.Text;
        string Issue = txtIssue.Text;
        string IssueDate = txtIssueDate.Text;
        //Create attribute to store error message
        string Error = "";
        //Validate the data
        Error = ACustomerService.Valid(CustomerID, ProductID, Issue, IssueDate);
        if (Error == "")
        {
            //Capture the attributes
            ACustomerService.CustomerID = Convert.ToInt32(CustomerID);
            ACustomerService.ProductID = Convert.ToInt32(ProductID);
            ACustomerService.IssueDate = Convert.ToDateTime(IssueDate);
            ACustomerService.Issue = Issue;
            ACustomerService.ReturnEligibility = chkReturnEligibility.Checked;
            //Create a new instance of stock collection
           clsCustomerServiceCollection CustomerServiceList= new clsCustomerServiceCollection();

            //If this is a new record then add the data
            if (ACustomerService == -1)
            {
                //Set the ThisCustomerService property
               CustomerServiceList.ThisCustomerService = ACustomerService;
                //Add the new record
               CustomerServiceList.Add();
            }
            //If it's not it must be updated
            else
            {
                //Find the record to update
               CustomerServiceList.ThisCustomerService.Find(ProductID);
                //Set the ThisCustomerService property
               CustomerServiceList.ThisCustomerService = ACustomerService;
                //Update the record
               CustomerServiceList.Update();
            }
            //Redirect to the list page
            Response.Redirect("CustomerServiceList.aspx");
        }
        else
        {
            //Display error message
            lblError.Text = Error;
            Response.Redirect("CustomerServiceViewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the CustomerService class
        clsCustomerService ACustomerService = new clsCustomerService();
        //variable to store the primary key
        Int32 IssueID;
        //variable to store result of find operation
        Boolean Found = false;
        //get the primary key entered by user
        IssueID = Convert.ToInt32(txtIssueID.Text);
        //find the record
        Found = ACustomerService.Find(IssueID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtIssueID.Text = ACustomerService.IssueID.ToString();
            txtCustomerID.Text = ACustomerService.CustomerID.ToString();
            txtProductID.Text = ACustomerService.ProductID.ToString();
            txtIssue.Text = ACustomerService.Issue;
            txtIssueDate.Text = ACustomerService.IssueDate.ToString();
            chkReturnEligibility.Checked = ACustomerService.ReturnEligibility;
        }
    }
}