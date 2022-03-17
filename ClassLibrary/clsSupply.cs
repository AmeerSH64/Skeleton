using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        private bool mIsAvailable;
        public bool IsAvailable { 
            get
            {
                return mIsAvailable;
            }
            set
            {
                mIsAvailable = value;
            }
        }
        private DateTime mDateAvailable;
        public DateTime DateAvailable { 
            get
            {
                return mDateAvailable;
            }
            set
            {
                mDateAvailable = value;
            }
        }
        private string mSupplierName;
        public string SupplierName { 
            get
            {
                return mSupplierName;
            }
            set
            {
                mSupplierName = value;
            }
        }
        private string mProductName;
        public string ProductName { 
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }
        private double mProductPrice;
        public double ProductPrice { 
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            } 
        }
        private Int32 mSupplierNo;
        public Int32 SupplierNo { 
            get
            {
                return mSupplierNo;
            }
            set
            {
                mSupplierNo = value;
            }
        }

        public bool Find(Int32 supplierNo)
        {
            mSupplierNo = 2;
            mSupplierName = "Microsoft";
            mProductName = "Surface Laptop";
            mProductPrice = 900;
            mIsAvailable = true;
            mDateAvailable = Convert.ToDateTime("10/02/2022");
            return true;
        }
    }
}