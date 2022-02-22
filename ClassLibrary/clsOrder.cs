using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderNumber { get; set; }
        public int TrackingNumber { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string CustomerName { get; set; }
        public bool ConfirmOrder { get; set; }
        public DateTime OrderDate { get; set; }
    }
}