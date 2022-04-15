using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplyCollection
    {
        public int Count { get; set; }

        public List<clsSupply> SupplierList { get; set; }
        public clsSupply ThisSupplier { get; set; }
    }
}