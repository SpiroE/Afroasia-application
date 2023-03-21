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
        //Create an instance of the class we want to create
        clsStock AStock = new clsStock();
        //Get data from the session object
        AStock = (clsStock) Session["AStock"];
        //Display the product name for this entry
        Response.Write(AStock.ProductID);
        Response.Write(AStock.ProductName);
        Response.Write(AStock.ProductAvailability);
        Response.Write(AStock.StockQuantity);
        Response.Write(AStock.StockArrivalDate);
        Response.Write(AStock.TrackingID);
    }
}