using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplyCollection
    {
        //Private data member for the count.
        private int mCount;
        //Public property for the count.
        public int Count { 
            get
            {
                //Return the private data.
                return mCount;
            }
            set
            {

            } 
        }
        //Private data member for the list.
        List<clsSupply> mSupplierList = new List<clsSupply>();
        //Public property for the list.
        public List<clsSupply> SupplierList { 
            get
            {
                //Return the private data.
                return mSupplierList;
            } 
            set
            {
                //Set the private data.
                mSupplierList = value;
            }
        }
        //Private data member ThisSupplier.
        clsSupply mThisSupplier = new clsSupply();
        public clsSupply ThisSupplier { 
            get
            {
                //Return the private data.
                return mThisSupplier;
            } 
            set
            {
                //Set the private data.
                mThisSupplier = value;
            } 
        }
        //Constructor for the class.
        public clsSupplyCollection()
        {
            //Variable for the index.
            Int32 Index = 0;
            //Variable to store the record count.
            Int32 RecordCount = 0;
            //Object for data connection.
            clsDataConnection DB = new clsDataConnection();
            //Execte the stored procedure.
            DB.Execute("sproc_tblSupplier_SelectAll");
            //Get the record count.
            RecordCount = DB.Count;
            //While there are records to process.
            while (Index < RecordCount)
            {
                //Create a blank supplier.
                clsSupply Supplier = new clsSupply();
                //Read in the fields from the current record.
                Supplier.SupplierNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierNo"]);
                Supplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                Supplier.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                Supplier.ProductPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductPrice"]);
                Supplier.DateAvailable = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAvailable"]);
                Supplier.IsAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                //Add the record to the private data member.
                mSupplierList.Add(Supplier);
                //Point at the next record.
                Index++;
            }

        }

        public int Add()
        {
            //Add a new record to the Supplier table.
            //Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters.
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductName", mThisSupplier.ProductName);
            DB.AddParameter("@ProductPrice", mThisSupplier.ProductPrice);
            DB.AddParameter("@DateAvailable", mThisSupplier.DateAvailable);
            DB.AddParameter("@IsAvailable", mThisSupplier.IsAvailable);
            //Execute the procedure, returning the result.
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            //Update an existing record in the table.
            //Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure.
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ProductName", mThisSupplier.ProductName);
            DB.AddParameter("@ProductPrice", mThisSupplier.ProductPrice);
            DB.AddParameter("@DateAvailable", mThisSupplier.DateAvailable);
            DB.AddParameter("@IsAvailable", mThisSupplier.IsAvailable);
            //Execute the procedure.
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //Deletes a record from tblSupplier.
            //Connect to the database.
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure.
            DB.AddParameter("@SupplierNo", mThisSupplier.SupplierNo);
            //Execute the procedure.
            DB.Execute("sproc_tblSupplier_Delete");
        }
    }
}