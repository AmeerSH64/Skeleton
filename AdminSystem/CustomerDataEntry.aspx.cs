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

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, DataOfBirth, Address);
        if (Error == "")
        {

            //capture the customer no.
            ACustomer.CustomerName = txtCustomerName.Text;

            //caption the date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(lblDateOfBirth);

            //capture the address
            ACustomer.Address = Address;

            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Write("CustomerViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }



        
    }
}