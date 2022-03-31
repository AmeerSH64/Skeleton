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
        private Int32 mProductPrice;
        public Int32 ProductPrice
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
                mProductPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ProductPrice"]);
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

        public string Valid(string supplierName, string productName, string productPrice, string dateAvailable)
        {
            //This method accepts four strings for validation.
            //The function returns a string containing an error message.
            //If there are no errors, a blank string is returned.
            //Create the error message.
            String error = "";
            //Create a temp variable for dates.
            DateTime DateTemp;
            //Creaet temp variable for integers.
            Int32 priceTemp;
            //If the Supplier name is null.
            if (supplierName.Length == 0)
            {
                error = error + "The supplier name field is empty. : ";
            }
            //If the Supplier name is bigger than 50 characters(max).
            if (supplierName.Length > 50)
            {
                error = error + "The supplier name cannot be longer than 50 characters. : ";
            }
            try
            {
                //Convert the dateAdded value into DateTime.
                DateTemp = Convert.ToDateTime(dateAvailable);
                //If date available is in the past.
                if (DateTemp < DateTime.Now.Date)
                {
                    error = error + "The date available cannot be in the past. : ";
                }
                //If date available is in the future.
                if (DateTemp > DateTime.Now.Date)
                {
                    error = error + "The date available cannot be in the future. : ";
                }
            }
            catch
            {
                error = error + "That is an invalid date. : ";
            }
            //If the product name is null.
            if (productName.Length == 0)
            {
                error = error + "The product name cannot be empty. : ";
            }
            //If the product name is bigger than 50 characters(max).
            if (productName.Length > 50)
            {
                error = error + "The product name cannot be longer than 50 characters. : ";
            }
            try
            {
                priceTemp = Convert.ToInt32(productPrice);
                //If the product price is less than one.
                if (priceTemp < 1)
                {
                    error = error + "The product price cannot be less than 1. : ";
                }
                //If the price is over 9999(max).
                if (priceTemp > 9999)
                {
                    error = error + "The product price cannot be over 9999. : ";
                }
            }
            catch
            {
                error = error + "That is not a valid price, : ";
            }
            //Return any error messages.
            return error;
        }
    }
}