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
        // Creates a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // Captures the Customer ID
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerPhoneNo = txtCustomerPhoneNo.Text;
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.CustomerPass = txtCustomerPass.Text;
        ACustomer.AccountCreationDate = Convert.ToDateTime(txtAccountCreationDate.Text);
        ACustomer.AccountChecker = Convert.ToBoolean(chkAccountChecker.Checked);
        // Stores the Customer ID in the session object
        Session["ACustomer"] = ACustomer;
        // Navigates to the viewer page
        Response.Redirect("1~CustomerViewer.aspx");
    }
}