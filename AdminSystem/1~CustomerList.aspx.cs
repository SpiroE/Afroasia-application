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
        // If it's the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the List Box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        // Creates a new instance of the Class
        clsCustomerCollection Customers = new clsCustomerCollection();
        // Set the data source to list the customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        // Setting the name of the Primary Key
        lstCustomerList.DataValueField = "CustomerID";
        // Setting the data field to display Customer Email
        lstCustomerList.DataTextField = "CustomerEmail";
        // Bind data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store the value -1 into the session object to indicate it is a new record
        Session["CustomerID"] = -1;
        // Redirect to Customer Data Entry page
        Response.Redirect("1~CustomerDataEntry.aspx");
    }
}