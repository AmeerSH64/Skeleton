using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for ths list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //adds a new record to the data based on the values of mThisOrder
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TrackingNumber", mThisOrder.TrackingNumber);
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@ConfirmOrder", mThisOrder.ConfirmOrder);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.AddParameter("@TrackingNumber", mThisOrder.TrackingNumber);
            DB.AddParameter("@ProductName", mThisOrder.ProductName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@ConfirmOrder", mThisOrder.ConfirmOrder);
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the record based on a full or partial Product Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Product Name parameter to the database
            DB.AddParameter("@ProductName", ProductName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.ConfirmOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["ConfirmOrder"]);
                AnOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                AnOrder.TrackingNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["TrackingNumber"]);
                AnOrder.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //poibnt at the next record
                Index++;
            }
        }
    }
}