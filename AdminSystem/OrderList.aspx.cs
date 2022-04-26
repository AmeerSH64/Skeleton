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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of order in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNumber";
        //set the data field to display
        lstOrderList.DataTextField = "ProductName";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void bntAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this a new record
        Session["OrderNumber"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.apsx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderNumber;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record edit
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNumber"] = OrderNumber;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderNumber;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value pf the record to edit
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNumber"] = OrderNumber;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Order Collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductName(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "Order Number";
        //set the name of the field to display
        lstOrderList.DataTextField = "Product Name";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the Order Collecton
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByProductName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "Order Number";
        //set the name of the field to display
        lstOrderList.DataTextField = "Product Name";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}