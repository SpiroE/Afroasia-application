﻿using System;
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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        string CustomerID = txtCustomerID.Text;
        string Address = txtAddressID.Text;
        string ProductID = txtProductID.Text;
        string NoOfCases = txtNoOfCases.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = AnOrder.Valid(CustomerID, Address, ProductID, NoOfCases, DateAdded);
        if (Error == "")
        {
            //capture the data from the text
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.Address = Address;
            AnOrder.ProductID = Convert.ToInt32(ProductID);
            AnOrder.NoOfCases = Convert.ToInt32(NoOfCases);
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            // Store the order into a session object
            Session["AnOrder"] = AnOrder;
            //Navigate to the viewer page
            Response.Redirect("4~OrderViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found show the values of the properties in the form
        if(Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtAddressID.Text = AnOrder.Address;
            txtProductID.Text = AnOrder.ProductID.ToString();
            txtNoOfCases.Text = AnOrder.NoOfCases.ToString();
            txtDateAdded.Text = AnOrder.DateAdded.ToString();
            chkFulfilled.Checked = AnOrder.Fulfilled;
        }

    }
}