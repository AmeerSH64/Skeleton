using System;

namespace ClassLibrary
{
    public class clsSupply
    {
        public bool IsAvailable { get; set; }
        public DateTime DateAvailable { get; set; }
        public string SupplierName { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}