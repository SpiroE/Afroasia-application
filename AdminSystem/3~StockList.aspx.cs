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
        //If this is the first time the page is beign displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //Create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        //Set the data source to the stock list in the collection
        lstStockList.DataSource = Stock.StockList;
        //Set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //Set the data field to display
        lstStockList.DataTextField = "ProductName";
        //Bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 to the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //Redirect to the data entry page
        Response.Redirect("3~StockDataEntry.aspx");
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key of the record we want to edit
        Int32 ProductID;
        //If a record has been selected on the list
        if (lstStockList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //Store the data in the session object
            Session["ProductID"] = ProductID;
            //Redirect to the edit page
            Response.Redirect("3~StockDataEntry.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key of the record we want to delete
        Int32 ProductID;
        //If a record has been selected on the list
        if (lstStockList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            //Store the data in the session object
            Session["ProductID"] = ProductID;
            //Redirect to the edit page
            Response.Redirect("3~StockConfirmDelete.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Create an instance of stock collection 
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ReportByProductName(txtFilterProd.Text);
        lstStockList.DataSource = AllStock.StockList;
        //Set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //Set the name of the field to display
        lstStockList.DataTextField = "ProductName";
        //Bind the data to the list
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Create an instance of stock collection 
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ReportByProductName("");
        //Clear any existing filter to tidy the interface
        txtFilterProd.Text = "";
        lstStockList.DataSource = AllStock.StockList;
        //Set the name of the primary key
        lstStockList.DataValueField = "ProductID";
        //Set the name of the field to display
        lstStockList.DataTextField = "ProductName";
        //Bind the data to the list
        lstStockList.DataBind();
    }
}