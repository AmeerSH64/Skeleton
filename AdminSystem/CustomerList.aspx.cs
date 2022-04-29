using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomer();
        }

    }

    void DisplayCustomer()
    {
        //create an instance of the Customer book
        clsCustomerCollection Customers = new clsCustomerCollection();
        //Set the data source to a list of customers in the collection.
        lstCustomerList.DataSource = Customers.CustomerList;
        //Set the name of the primary key.
        lstCustomerList.DataValueField = "CustomerName";
        //Set the data field to display.
        lstCustomerList.DataTextField = "CustomerNo";
        //Bind the data to the list.
        lstCustomerList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerBookDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("CustomerBookDataEntry.aspx");

        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a ecord to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value to the record to edit
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspxx");

        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";

        }
    }
}