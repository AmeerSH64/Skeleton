using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //DateAdded private member 
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //ordernumber private member variable
        private Int32 mOrderNumber;
        //OrderNumber public property
        public Int32 OrderNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNumber;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNumber = value;
            }
        }

        //TrackingNumber private member variable
        private Int32 mTrackingNumber;
        //TrackingNumber public property
        public Int32 TrackingNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mTrackingNumber;
            }
            set
            {
                //this line of code allows data into the property
                mTrackingNumber = value;
            }
        }

        //ProductName private member variable
        private String mProductName;
        //ProductNumber public property
        public String ProductName
        {
            get
            {
                //this line of code sends data out of the property
                return mProductName;
            }
            set
            {
                //this line of code allows data into the property
                mProductName = value;
            }
        }

        //Price Private member variable
        private Int32 mPrice;
        //Price public property
        public Int32 Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        //CustomerName private member varaible
        private String mCustomerName;
        //CustomerName public property
        public String CustomerName
        {
            get
            {
                //this line of coe sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        //priavte data member for ConfirmOrder
        private Boolean mConfirmOrder;
        //public property for ConfirmOrder
        public bool ConfirmOrder
        {
            get
            {
                //return the ConfirmOrder data
                return mConfirmOrder;
            }
            set
            {
                //set the ConfirmOrder data
                mConfirmOrder = value;
            }
        }

        public bool Find(int OrderNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@OrderNumber", OrderNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNumber");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mConfirmOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["ConfirmOrder"]);
                mTrackingNumber = Convert.ToInt32(DB.DataTable.Rows[0]["TrackingNumber"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string TrackingNumber, string ProductName, string Price, string CustomerName, string DateAdded)
        {
            //create a string variable to store tthe error
            String Error = "";
            //create a temporary variable to store data values
            DateTime DateTemp;
            //if the TrackingNumber is blank
            if (TrackingNumber.Length == 0)
            {
                //record the error
                Error = Error + "The tracking number way not be blank : ";
            }
            //if the tracking number is greater than 6 characters
            if (TrackingNumber.Length > 32)
            {
                //record the error
                Error = Error = "The Tracking Number must be less than 32 characters ; ";
            }
            //copy the DateAdded value to the DateTemp varaible
            DateTemp = Convert.ToDateTime(DateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //return any error messages
            return Error;
        }
    }
}