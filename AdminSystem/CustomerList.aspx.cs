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
        //get the number of the address to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerNo != -1)
            {
                //update the list box
                DisplayCustomers();

            }
            
        }

    }

    void DisplayCustomer()
    {
        //create an instance of the Customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo;
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.Address.ToString();
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtTotalPrice.Text = CustomerBook.ThisCustomer.TotalPrice();
        txtOver18.Text = CustomerBook.ThisCustomer.Over18;

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
}