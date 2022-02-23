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
        //Create an instance of clsSupply.
        clsSupply Supplier = new clsSupply();
        //Capture the Supplier name.
        Supplier.SupplierName = txtSupplierName.Text;
        //Capture the Product name.
        Supplier.ProductName = txtProductName.Text;
        //Store the data in the session object.
        Session["Supplier"] = Supplier;
        //Navigate to the viewer page.
        Response.Redirect("SupplyViewer.aspx");
    }
}