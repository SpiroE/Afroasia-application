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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the data from the text
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnOrder.Address = txtAddressID.Text;
        AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
        AnOrder.NoOfCases = Convert.ToInt32(txtNoOfCases.Text);
        AnOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnOrder.Fulfilled = chkFulfilled.Checked;
        // Store the order into a session object
        Session["AnOrder"] = AnOrder;
        //Navigate to the viewer page
        Response.Redirect("4~OrderViewer.aspx");
    }
}