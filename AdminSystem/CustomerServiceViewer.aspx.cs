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
        //create a new instance of clsCustomerService
        clsCustomerService ACustomerService = new clsCustomerService();
        //get the data from the session object
        ACustomerService = (clsCustomerService)Session["ACustomerService"];
        //display the CustomerID for this entry
        Response.Write(ACustomerService.IssueID);
        Response.Write(ACustomerService.CustomerID);
        Response.Write(ACustomerService.ProductID);
        Response.Write(ACustomerService.Issue);
        Response.Write(ACustomerService.IssueDate);
        Response.Write(ACustomerService.ReturnEligibility);
    }
}