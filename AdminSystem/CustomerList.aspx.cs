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
        //if this is the forst time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }

    }

    void DisplayCustomers()
    {
        //create an instance of the Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customer in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set teh name of the primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the data field to display
        lstCustomerList.DataTextField = "Address";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}