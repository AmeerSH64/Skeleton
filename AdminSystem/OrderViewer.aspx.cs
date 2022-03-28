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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the Order Number for this entry
        Response.Write(AnOrder.OrderNumber);
        //display the Tracking Number for this entry
        Response.Write(AnOrder.TrackingNumber);
        //display the Product Name for this entry
        Response.Write(AnOrder.ProductName);
        //display the Price for this entry
        Response.Write(AnOrder.Price);
        //display the Customer Name for this entry
        Response.Write(AnOrder.CustomerName);
        //display the Order Date for this entry
        Response.Write(AnOrder.OrderDate);


    }
}