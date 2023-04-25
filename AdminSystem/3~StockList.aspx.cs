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
}