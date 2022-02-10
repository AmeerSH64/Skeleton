using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupply
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create.
            clsSupply Supplier = new clsSupply();
            //Test to see that it exists.
            Assert.IsNotNull(Supplier);
        }
    }
}
