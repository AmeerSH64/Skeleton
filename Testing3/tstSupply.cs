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

        [TestMethod]
        public void IsAvaiablePropertyOK()
        {
            //Create an instance of the class we want to create.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            Boolean testData = true;
            //Assign the data to the property.
            Supplier.IsAvailable = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.IsAvailable, testData);
        }

        [TestMethod]
        public void DateAvailablePropertyOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            DateTime testData = DateTime.Now.Date;
            //Assign the data to the property.
            Supplier.DateAvailable = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.DateAvailable, testData);
        }

        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            String testData = "Microsoft";
            //Assign the data to the property.
            Supplier.SupplierName = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.SupplierName, testData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            String testData = "MacBook Pro";
            //Assign the data to the property.
            Supplier.ProductName = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.ProductName, testData);
        }

        [TestMethod]
        public void ProductPricePropertyOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            double testData = 100;
            //Assign the data to the property.
            Supplier.ProductPrice = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.ProductPrice, testData);
        }
    }
}
