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
        string CustomerID = txtCustomerID.Text;
        // Captures the Customer Name
        string CustomerName = txtCustomerName.Text;
        // Captures the Customer Phone Number
        string CustomerPhoneNo = txtCustomerPhoneNo.Text;
        // Captures the Customer Email
        string CustomerEmail = txtCustomerEmail.Text;
        // Captures the Customer Password
        string CustomerPass = txtCustomerPass.Text;
        // Captures the Account Creation Date
        string AccountCreationDate = txtAccountCreationDate.Text;
        // Store any error messages
        string Error = "";
        // Validates the data
        Error = ACustomer.Valid(CustomerName, CustomerPhoneNo, CustomerEmail, CustomerPass, AccountCreationDate);
        if (Error == "")
        {
            // Captures the Customer ID
            ACustomer.CustomerID = Convert.ToInt32(CustomerID);
            // Captures the Customer Name
            ACustomer.CustomerName = CustomerName;
            // Captures the Customer Phone Number
            ACustomer.CustomerPhoneNo = CustomerPhoneNo;
            // Captures the Customer Email
            ACustomer.CustomerEmail = CustomerEmail;
            // Captures the Customer Password
            ACustomer.CustomerPass = CustomerPass;
            // Captures the Account Creation Date
            ACustomer.AccountCreationDate = Convert.ToDateTime(AccountCreationDate);
            // Capture the Account
            ACustomer.AccountChecker = chkAccountChecker.Checked;
            // Creates a new instance of clsCustomerCollection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            // If this is a new record (CustomerID = -1) then...
            if (Convert.ToInt32(CustomerID) == -1)
            {
                // Setting the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                // Add the new record
                CustomerList.Add();
            }
            // Else it is an update
            else
            {
                // Find record to update
                CustomerList.ThisCustomer.Find(Convert.ToInt32(CustomerID));
                // Setting the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                // Update record
                CustomerList.Update();
            }
            // Redirect back to Customer List
            Response.Redirect("1~CustomerList.aspx");
        }
        else
        {
            // Display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Creates a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        // Variable to store Primary Key
        Int32 CustomerID;
        // Variable to store the result of the find method
        Boolean Found = false;
        // Gets the Primary Key the user entered
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        // Finds the record
        Found = ACustomer.Find(CustomerID);
        if (Found == true)
        {
            // Displays every value of the properties in the form
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerPhoneNo.Text = ACustomer.CustomerPhoneNo;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPass.Text = ACustomer.CustomerPass;
            txtAccountCreationDate.Text = ACustomer.AccountCreationDate.ToString();
            chkAccountChecker.Checked = ACustomer.AccountChecker;
        }
    }
}