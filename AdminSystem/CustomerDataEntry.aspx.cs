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
        //capture the customer no
        string CustomerNo = txtCustomerNo.Text;

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
            if (Convert.ToInt32(CustomerNo) == 1)
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
            Response.Write("CustomerViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }



        
    }
}