using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderNumber;
        //variable to store the result to the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        //find the record
        Found = AnOrder.Find(OrderNumber);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtTrackingNumber.Text = AnOrder.TrackingNumber.ToString();
            txtProductName.Text = AnOrder.OrderNumber.ToString();
            txtPrice.Text = AnOrder.Price.ToString();
            txtCustomerName.Text = AnOrder.CustomerName;
            txtDateAdded.Text = AnOrder.DateAdded.ToString();
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
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
        AOrder.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}