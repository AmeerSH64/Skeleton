using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        private int mSupplierNo;
        public int SupplierNo
        {
            get
            {
                //Acquiring the data from the property.
                return mSupplierNo;
            }
            set
            {
                //Changing the data of the property.
                mSupplierNo = value;
            }
        }
        private bool mIsAvailable;
        public bool IsAvailable
        {
            get
            {
                //Acquiring the data from the property.
                return mIsAvailable;
            }
            set
            {
                //Changing the data of the property.
                mIsAvailable = value;
            }
        }
        private DateTime mDateAvailable;
        public DateTime DateAvailable { 
            get
            {
                //Acquiring data from the property.
                return mDateAvailable;
            }
            set
            {
                //Changing the data of the property.
                mDateAvailable = value;
            }
        }
        private string mSupplierName;
        public string SupplierName { 
            get
            {
                //Acquiring data from the property.
                return mSupplierName;
            }
            set
            {
                //Changing the data of the property.
                mSupplierName = value;
            }
        }
        private string mProductName;
        public string ProductName
        {
            get
            {
                //Acquiring the data from the property.
                return mProductName;
            }
            set
            {
                //Changing the data of the property.
                mProductName = value;
            }
        }
        private double mProductPrice;
        public double ProductPrice
        {
            get
            {
                //Acquiring the data from the property.
                return mProductPrice;
            }
            set
            {
                //Changing the data of the property.
                mProductPrice = value;
            }
        }


        public bool Find(int supplierNo)
        {
            //Create an instance of the DataConnection class.
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter to search for.
            DB.AddParameter("@SupplierNo", supplierNo);
            //Execute the stored procedure.
            DB.Execute("sproc_tblSupplier_FilterBySupplierNo");
            //If a record is found, it should be 1 or 0.
            if (DB.Count == 1)
            {
                //Copy the data from the database into the private data members.
                mSupplierNo = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierNo"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mIsAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
                mDateAvailable = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAvailable"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ProductPrice"]);
                //Return if everything worked.
                return true;
            }
            //If no record was found.
            else
            {
                //Return false indicating a problem.
                return false;
            }
        }
    }
}