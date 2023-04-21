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
        if(IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Fulfilled";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        Response.Redirect("4~OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if(lstOrderList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("4~OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please selesct a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;
        if(lstOrderList.SelectedIndex != -1)
        {
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNo"] = OrderNo;
            Response.Redirect("4~OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByFulfilled(Convert.ToBoolean(txtFulfilledInput.Text));
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Fulfilled";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        DisplayOrders();
        txtFulfilledInput.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "Fulfilled";
        lstOrderList.DataBind();
    }
}