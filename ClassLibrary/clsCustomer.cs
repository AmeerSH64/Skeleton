using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Over18 { get; set; }
    }
} 