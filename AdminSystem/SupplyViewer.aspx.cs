using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupply Supplier = new clsSupply();
        //Get the data from the session object.
        Supplier = (clsSupply)Session["Supplier"];
        //Display the Supplier name for this entry.
        Response.Write(Supplier.SupplierName);
    }
}