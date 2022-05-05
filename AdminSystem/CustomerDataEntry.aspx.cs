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
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed 
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if(CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the data for this record
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.Address;
        txtDateOfBirth.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtCustomerTotalPrice.Text = CustomerBook.ThisCustomer.TotalPrice.ToString();
        chkOver18.Checked = CustomerBook.ThisCustomer.Over18;


    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        

        //capture the customer name
        string CustomerName = txtCustomerName.Text;

        //capture date of birth
        string DataOfBirth = txtDateOfBirth.Text;

        //caption address
        string Address = txtCustomerAddress.Text;

        //capture TotalPrice
        string TotalPrice = txtCustomerTotalPrice.Text;

        //variable to store any error messages
        string Error="";
        //validate the data
        Error = ACustomer.Valid(CustomerName, DataOfBirth, Address);
        if (Error == "")
        { 
            //capture the customer no
            ACustomer.CustomerNo = Convert.ToInt32(CustomerNo);

            //capture the customer name.
            ACustomer.CustomerName = CustomerName;

            //caption the date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(lblDateOfBirth);

            //capture the address
            ACustomer.Address = Address;

            //capture totavlprice
            ACustomer.TotalPrice = Convert.ToInt32(TotalPrice);

            //capture Over18
            ACustomer.Over18 = chkOver18.Checked;

            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            //if this is a new record i.e CustomerNo = -1 then add the data
            if (Convert.ToInt32(CustomerNo) == -1)
            {
                //sett the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();

            }
            else 
            {
                //find he record to update
                CustomerList.ThisCustomer.Find(Convert.ToInt32(CustomerNo));
                //set the thisCUSTOMER Property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();


            }
            

            
            //redirect to the viewer page
            Response.Write("CustomerList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }



        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //find the record
        Found = ACustomer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the value of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerAddress.Text = ACustomer.Address;
            txtCustomerTotalPrice.Text = ACustomer.TotalPrice.ToString();
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();


        }
    }
}