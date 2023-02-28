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
        // Creates a new instance of clsAddress
        clsCustomer ACustomer = new clsCustomer();
        // Get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        // Displays the Customer ID for this entry
        Response.Write(ACustomer.CustomerID);
        Response.Write(ACustomer.CustomerName);
        Response.Write(ACustomer.CustomerPhoneNo);
        Response.Write(ACustomer.CustomerEmail);
        Response.Write(ACustomer.CustomerPass);
        Response.Write(ACustomer.AccountCreationDate);
        Response.Write(ACustomer.AccountChecker);
    }
}