﻿using System;
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
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //Get the data from the session object
        AnOrder =(clsOrder)Session["AnOrder"];
        //display the order number for this entry
        Response.Write(AnOrder.OrderNo);
        Response.Write(AnOrder.CustomerID);
        Response.Write(AnOrder.Address);
        Response.Write(AnOrder.ProductID);
        Response.Write(AnOrder.NoOfCases);
        Response.Write(AnOrder.DateAdded);
        Response.Write(AnOrder.Fulfilled);

    }
}