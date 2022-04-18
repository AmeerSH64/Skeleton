using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If the is the first time the page is displayed.
        if (IsPostBack == false)
        {
            //Update the list box.
            DisplaySuppliers();
        }
    }

    void DisplaySuppliers()
    {
        //Create an instance of the Supplier collection.
        clsSupplyCollection AllSuppliers = new clsSupplyCollection();
        //Set the data source to list of addresses in the collection.
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        //Set the name of the primary key.
        lstSupplierList.DataValueField = "SupplierNo";
        //Set the data field to display.
        lstSupplierList.DataTextField = "SupplierName";
        //Bind the data to the list.
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 to indicate a new record.
        Session["SupplierNo"] = -1;
        //Redirect to the data intry page.
        Response.Redirect("SupplyDataEntry.aspx");
    }
}