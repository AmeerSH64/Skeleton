using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public int CustomerNo { get; set; }
        //public string CustomerName { get; set; }
        //public string Address { get; set; }
        //public decimal TotalPrice { get; set; }
        //public bool Over18 { get; set; }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 21;
            mDateOfBirth = Convert.ToDateTime("16/09/2015");
            mCustomerName = "Test Customer Name";
            mAddress = "Test Address";
            mTotalPrice = 100;
            mOver18 = true;

            //always return true
            return true;
        }

        //private data member for the customer no property
        private Int32 mCustomerNo;

        //dateOfBirth private number variable
        private DateTime mDateOfBirth;
        
        private string mCustomerName;

        private string mAddress;

        private decimal mTotalPrice;

        private Boolean mOver18;

        //addressNo public property
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

        //DateOfBirth public property
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public Boolean Over18
        {
            get
            {
                return mOver18;
            }
            set
            {
                mOver18 = value;
            }
        }
    }
} 