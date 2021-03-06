using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted frim the session object
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the order class
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(OrderNumber);
        //delete the record
        Order.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}