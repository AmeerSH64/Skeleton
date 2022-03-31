using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address to the search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNumber");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);

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

        public string Valid(string CustomerName, string DateOfBirth, string Address)
        {
            //create a string variable to store the error
            String Error = "";
            //ctreate a temporay variable to store data value
            DateTime DateTemp;
            //if the customer name is blank
            if (CustomerName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer name may not be left blank : ";
            }
            //if the customer name is greater than 50 characters
            if (CustomerName.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Name must be less than 50 characters :";
            }

            try
            {
                //copy the DateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);
                if (DateTemp < DateTime.Now.Date)
                {
                     //record the error
                     Error = Error + "The date cannot be in the past : ";
                }
                 //check to see if the date is greater than todays date
                 if (DateTemp > DateTime.Now.Date)
                 {
                      //record the error
                      Error = Error + "The date cannot be in the future : ";
                 }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the Address blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the Address is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 characters : ";
            }
            //is the street blank
            if (Address.Length == 0)
            {
                //record the error
                Error = Error + "The Address may not be blank : ";
            }
            //if the street is too long
            if (Address.Length > 50)
            {
                //record the error
                Error = Error + "The Address must be less than 50 characters : ";
            }


            //return any error messages
            return Error;
        }

    }
} 