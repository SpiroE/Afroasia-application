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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //Create an instance of the class we want to create
        clsStock AStock = new clsStock();
        //Capture the the attributes
        AStock.ProductID = Convert.ToInt32(txtProductID.Text);
        AStock.ProductName = txtProductName.Text;
        AStock.ProductAvailability = Convert.ToBoolean(chkProductAvailability.Checked);
        AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        AStock.StockArrivalDate = Convert.ToDateTime(txtStockArrivalDate.Text);
        AStock.TrackingID = Convert.ToInt32(txtTrackingID.Text);
        //Store the attribute in the session object
        Session["AStock"] = AStock;
        //Navigate to viewer page
        Response.Redirect("3~StockViewer.aspx");
    }
}