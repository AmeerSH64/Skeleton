using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable for primary key with page level scope.
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of suppliers to be processed.
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            //If this is not a new record.
            if (SupplierNo != -1)
            {
                //Display the current data in the record.
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        //Create an instance of the supplier book.
        clsSupplyCollection SupplierBook = new clsSupplyCollection();
        //Find the record.
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //Display the data for this record.
        txtSupplierNo.Text = SupplierBook.ThisSupplier.SupplierNo.ToString();
        txtSupplierName.Text = SupplierBook.ThisSupplier.SupplierName;
        txtProductName.Text = SupplierBook.ThisSupplier.ProductName;
        txtProductPrice.Text = SupplierBook.ThisSupplier.ProductPrice.ToString();
        txtDateAvailable.Text = SupplierBook.ThisSupplier.DateAvailable.ToString();
        chkIsAvaiable.Checked = SupplierBook.ThisSupplier.IsAvailable;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create an instance of clsSupply.
        clsSupply Supplier = new clsSupply();
        //Capture the Supplier no.
        String SupplierNo = txtSupplierNo.Text;
        //Capture the Supplier name.
        String SupplierName = txtSupplierName.Text;
        //Capture the Product name.
        String ProductName = txtProductName.Text;
        //Capture the Product price.
        String ProductPrice = txtProductPrice.Text;
        //Capture the date available.
        String DateAvailable = txtDateAvailable.Text;
        //Variable for error messages.
        String error = "";
        //Validate the data.
        error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
        if (error == "")
        {
            //Capture the Supplier no.
            Supplier.SupplierNo = Convert.ToInt32(SupplierNo);
            //Capture the Supplier name.
            Supplier.SupplierName = SupplierName;
            //Capture the Product name.
            Supplier.ProductName = ProductName;
            //Capture the Product price.
            Supplier.ProductPrice = Convert.ToInt32(ProductPrice);
            //Capture the date available.
            Supplier.DateAvailable = Convert.ToDateTime(DateAvailable);
            //Capture the availablity.
            Supplier.IsAvailable = chkIsAvaiable.Checked;
            //Create an instance of the supply collection class.
            clsSupplyCollection SupplyList = new clsSupplyCollection();
            //If the record is new, then add the data.
            if (Convert.ToInt32(SupplierNo) == -1)
            {
                //Set the ThisSupplier property.
                SupplyList.ThisSupplier = Supplier;
                //Add the record.
                SupplyList.Add();
            }
            //Otherwise, it must be an update.
            else
            {
                //Find the record to update.
                SupplyList.ThisSupplier.Find(Convert.ToInt32(SupplierNo));
                //Set the thisSupplier property.
                SupplyList.ThisSupplier = Supplier;
                //Update the record.
                SupplyList.Update();
            }
            //Navigate to the list page.
            Response.Redirect("SupplyList.aspx");
        }
        else
        {
            //Display the error meesage.
            lblError.Text = error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the Supplier class.
        clsSupply Supplier = new clsSupply();
        //Create a variable to store the primary key.
        Int32 SupplierNo;
        //Create a Boolean to store the results.
        Boolean Found = false;
        //Get a primary key from the user.
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //Find the record.
        Found = Supplier.Find(SupplierNo);
        //if found.
        if (Found == true)
        {
            //Display the properties in the form.
            txtSupplierName.Text = Supplier.SupplierName;
            txtProductName.Text = Supplier.ProductName;
            txtProductPrice.Text = Supplier.ProductPrice.ToString();
            txtDateAvailable.Text = Supplier.DateAvailable.ToString();
        }
    }
}