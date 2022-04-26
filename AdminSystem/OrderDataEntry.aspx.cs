using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderNumber;
    protected void Page_load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false)
        {
            //if this is not a record
            if (IsPostBack == false)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order
        clsOrderCollection Order = new clsOrderCollection();
        //find the record update
        Order.ThisOrder.Find(OrderNumber);
        //display the data for this record
        txtOrderNumber.Text = Order.ThisOrder.OrderNumber.ToString();
        txtTrackingNumber.Text = Order.ThisOrder.TrackingNumber.ToString();
        txtProductName.Text = Order.ThisOrder.ProductName;
        txtPrice.Text = Order.ThisOrder.Price.ToString();
        txtCustomerName.Text = Order.ThisOrder.CustomerName;
        chkConfirmOrder.Checked = Order.ThisOrder.ConfirmOrder;
        txtDateAdded.Text = Order.ThisOrder.DateAdded.ToString();
    }

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
        clsOrder AnOrder = new clsOrder();
        //capture the Tracking Number
        string TrackingNumber = txtTrackingNumber.Text;
        //capture the Product Name
        string ProductName = txtProductName.Text;
        //capture the Price
        string Price = txtPrice.Text;
        //capture the Customer Name
        string CustomerName = txtCustomerName.Text;
        //capture the Date Added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(TrackingNumber, ProductName, Price, CustomerName, DateAdded);
        if (Error == "")
        {
            //capture the Order Number
            AnOrder.OrderNumber = OrderNumber;
            //capture the Tracking Number
            AnOrder.TrackingNumber = Convert.ToInt32(TrackingNumber);
            //capture the Product Name
            AnOrder.ProductName = ProductName;
            //capture the Price
            AnOrder.Price = Convert.ToInt32(Price);
            //capture the Customer Name
            AnOrder.CustomerName = CustomerName;
            //capture the Date Added
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //capture Confirm Order
            AnOrder.ConfirmOrder = chkConfirmOrder.Checked;
            //create a new instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e. Order Number = -1 the add the data
            if (OrderNumber == -1)
            {
                //set the ThisOrder Property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderNumber);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the recorf
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}