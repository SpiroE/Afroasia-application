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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Store the Primary Key value of the record to be edited
        Int32 CustomerID;
        // If a record has been selected from the list then...
        if (lstCustomerList.SelectedIndex != -1)
        {
            // Get the Primary Key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            // Store the data in the session object
            Session["CustomerID"] = CustomerID;
            // Redirect to Edit page
            Response.Redirect("1~CustomerDataEntry.aspx");
        }
        // If no record has been selected then output the error text
        else
        {
            lblError.Text = "You need to select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Stire the Primary Key value of the record to be deleted
        Int32 CustomerID;
        // If a record has been selected from the list then...
        if (lstCustomerList.SelectedIndex != -1)
        {
            // Get the Primary Key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            // Store the data in the session object
            Session["CustomerID"] = CustomerID;
            // Redirect to Delete page
            Response.Redirect("1~CustomerConfirmDelete.aspx");
        }
        // If no record has been selected then output the error text
        else
        {
            lblError.Text = "You need to select a record to delete from the list";
        }
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Creates a new instance of the Class
        clsCustomerCollection Customers = new clsCustomerCollection();
        // Set the data source to list the customers in the collection
        Customers.ReportByCustomerName(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        // Setting the name of the Primary Key
        lstCustomerList.DataValueField = "CustomerID";
        // Setting the data field to display Customer Email
        lstCustomerList.DataTextField = "CustomerName";
        // Bind data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Creates a new instance of the Class
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByCustomerName("");
        // Clear existing filters to tidy up user interface
        txtFilter.Text = "";
        // Set the data source to list the customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        // Setting the name of the Primary Key
        lstCustomerList.DataValueField = "CustomerID";
        // Setting the data field to display Customer Email
        lstCustomerList.DataTextField = "CustomerName";
        // Bind data to the list
        lstCustomerList.DataBind();
    }
}