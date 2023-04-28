using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store primary key with page level scope
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of ProductID to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //If this is not a new record
            if (ProductID != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        //Create an instance of Stock collection
        clsStockCollection AllStock = new clsStockCollection();
        //Find the record to update
        AllStock.ThisStock.Find(ProductID);
        //Update the records
        txtProductID.Text = AllStock.ThisStock.ProductID.ToString();
        txtProductName.Text = AllStock.ThisStock.ProductName;
        txtStockQuantity.Text = AllStock.ThisStock.StockQuantity.ToString();
        txtStockArrivalDate.Text = AllStock.ThisStock.StockArrivalDate.ToString();
        txtTrackingID.Text = AllStock.ThisStock.TrackingID.ToString();
        chkProductAvailability.Checked = AllStock.ThisStock.ProductAvailability;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //Create an instance of the class we want to create
        clsStock AStock = new clsStock();
        //Capture the attributes
        string ProductName = txtProductName.Text;
        string StockQuantity = txtStockQuantity.Text;
        string StockArrivalDate = txtStockArrivalDate.Text;
        string TrackingID = txtTrackingID.Text;
        //Create attribute to store error message
        string Error = "";
        //Validate the data
        Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
        if (Error == "")
        {
            //Capture the attributes
            AStock.ProductID = ProductID;
            AStock.ProductName = ProductName;
            AStock.StockQuantity = Convert.ToInt32(StockQuantity);
            AStock.StockArrivalDate = Convert.ToDateTime(StockArrivalDate);
            AStock.TrackingID = Convert.ToInt32(TrackingID);
            AStock.ProductAvailability = chkProductAvailability.Checked;
            //Create a new instance of stock collection
            clsStockCollection StockList = new clsStockCollection();

            //If this is a new record then add the data
            if (ProductID == -1)
            {
                //Set the ThisStock property
                StockList.ThisStock = AStock;
                //Add the new record
                StockList.Add();
            }
            //If it's not it must be updated
            else
            {
                //Find the record to update
                StockList.ThisStock.Find(ProductID);
                //Set the ThisStock property
                StockList.ThisStock = AStock;
                //Update the record
                StockList.Update();
            }
            //Redirect to the list page
            Response.Redirect("3~StockList.aspx");
        }
        else
        {
            //Display error message
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the class we want to create
        clsStock AStock = new clsStock();
        //Create variable to store primary key
        Int32 ProductID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key from the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        //Find the record
        Found = AStock.Find(ProductID);
        //If the record is found
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtProductName.Text = AStock.ProductName;
            txtStockQuantity.Text = AStock.StockQuantity.ToString();
            txtStockArrivalDate.Text = AStock.StockArrivalDate.ToString();
            txtTrackingID.Text = AStock.TrackingID.ToString();
            chkProductAvailability.Checked = AStock.ProductAvailability;
        }
    }
}