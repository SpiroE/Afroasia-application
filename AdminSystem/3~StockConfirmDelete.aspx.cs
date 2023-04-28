using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //Variable to store the primary key value of the record we want to delete
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the ProductID to delete from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create an instance of the Stock collection class
        clsStockCollection AllStock = new clsStockCollection();
        //Find the record to delete
        AllStock.ThisStock.Find(ProductID);
        //Delete the record
        AllStock.Delete();
        //Redirect to main page
        Response.Redirect("3~StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect to main page
        Response.Redirect("3~StockList.aspx");
    }
}