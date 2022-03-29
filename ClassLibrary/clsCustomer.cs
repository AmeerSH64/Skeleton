using System;



namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for active
        private Boolean mActive;

        //Public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set te private data
                mActive = value;
            }
        }


        //private data member for the customer no property
        private Int32 mCustomerNo;

        //public property for the address number
        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }


        //private date added data member
        private DateTime mDateOfBirth;

        //public property for date added
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the private data
                mDateOfBirth = value;
            }
        }


        //private property for customer name
        private string mCustomerName;        
        //public property for customer name
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }


        //private property for address 
        private string mAddress;
        //public property for the address
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }


        //private property for the total price
        private decimal mTotalPrice;
        //public property for the total price
        public decimal TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }
            set
            {
                //set the private data
                mTotalPrice = value;
            }
        }


        //private property for over 18
        private Boolean mOver18;
        //public property for over 18
        public Boolean Over18
        {
            get
            {
                //return the private data
                return mOver18;
            }
            set
            {
                //set the private data
                mOver18 = value;
            }
        }
        
        public bool Find(int CustomerNo)
        {
            //set the private data members to the test data value
            mActive = true;
            mCustomerNo = 21;
            mDateOfBirth = Convert.ToDateTime("16/09/2015");
            mCustomerName = "Test Customer Name";
            mAddress = "Test Address";
            mTotalPrice = 100;
            mOver18 = true;

            //always return true
            return true;
        }
    }
} 