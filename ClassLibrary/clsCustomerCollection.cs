using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public Property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }
        public clsCustomer ThisCustomer { get; set; }
        
        
        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fiels from the current record
                ACustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over 18"]);
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["customerNo"]);
                ACustomer.CustomerName= Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.TotalPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalPrice"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }



        }
    }
}