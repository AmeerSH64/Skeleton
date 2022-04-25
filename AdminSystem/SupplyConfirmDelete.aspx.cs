using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the record to be deleted from the session object.
        SupplierNo = Convert.ToInt32(Session["AddressNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the supply book class.
        clsSupplyCollection SupplierBook = new clsSupplyCollection();
        //Find the record to delete.
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //Delete the record.
        SupplierBook.Delete();
        //Redirect to the main page.
        Response.Redirect("SupplyList.aspx");
    }
}