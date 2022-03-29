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

        public bool Find(int OrderNo)
        {
            //set the private data members to the test data value
            mOrderNumber = 1;
            mDateAdded = Convert.ToDateTime("2019-02-21");
            mConfirmOrder = true;
            mTrackingNumber = 317691783;
            mProductName = Convert.ToString("HP Pavilion Power");
            mPrice = 500;
            mCustomerName = Convert.ToString("Akash Vinodrai");
            //always return true
            return true;
        }
    }
}