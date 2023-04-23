using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // Store the Primary Key value of the record to be deleted
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the ID number of the Customer to be deleted
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Creates a new instance of clsCustomer
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        // Find the record to delete
        ACustomer.ThisCustomer.Find(CustomerID);
        // Delete the record
        ACustomer.Delete();
        // Redirect back to the main page
        Response.Redirect("1~CustomerList");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("1~CustomerList.aspx");
    }
}