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

    protected void bntOK_click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AOrder = new clsOrder();

        //capture the Order Number
        AOrder.OrderNumber = Convert.ToInt32(txtOrderNumber.Text);

        //capture the Tracking Number
        AOrder.TrackingNumber = Convert.ToInt32(txtTrackingNumber.Text);

        //capture the Product Name
        AOrder.ProductName = txtProductName.Text;

        //capture the Price
        AOrder.Price = Convert.ToInt32(txtPrice.Text);

        //capture the Customer Name
        AOrder.CustomerName = txtCustomerName.Text;

        //capture the Confirm Order
        AOrder.ConfirmOrder = Convert.ToBoolean(chkConfirmOrder.Checked);

        //capture the Order Date
        AOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }
}