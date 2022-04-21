using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstSupplyCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Test to see if it exists.
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Create test data which will be a list.
            List<clsSupply> TestList = new List<clsSupply>();
            //Add an item to the list.
            clsSupply TestItem = new clsSupply();
            //Set its properties.
            TestItem.SupplierNo = 5;
            TestItem.SupplierName = "Apple";
            TestItem.ProductName = "iMac";
            TestItem.ProductPrice = 1500;
            TestItem.DateAvailable = DateTime.Now.Date;
            TestItem.IsAvailable = true;
            //Add the item to the test list.
            TestList.Add(TestItem);
            //Assign the data to the property.
            AllSuppliers.SupplierList = TestList;
            //Test to see if the values match.
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Create test data.
            clsSupply TestSupplier = new clsSupply();
            //Set the properrties to the object.
            TestSupplier.SupplierNo = 5;
            TestSupplier.SupplierName = "Apple";
            TestSupplier.ProductName = "iMac";
            TestSupplier.ProductPrice = 1500;
            TestSupplier.DateAvailable = DateTime.Now.Date;
            TestSupplier.IsAvailable = true;
            //Assign the data to the property.
            AllSuppliers.ThisSupplier = TestSupplier;
            //Test to see if the values match.
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Create a list for test data.
            List<clsSupply> TestList = new List<clsSupply>();
            //Create and add an item to the list.
            clsSupply TestItem = new clsSupply();
            //Set its properties.
            TestItem.SupplierNo = 5;
            TestItem.SupplierName = "Apple";
            TestItem.ProductName = "iMac";
            TestItem.ProductPrice = 1500;
            TestItem.DateAvailable = DateTime.Now.Date;
            TestItem.IsAvailable = true;
            //Add the item to the list.
            TestList.Add(TestItem);
            //Assign to the property.
            AllSuppliers.SupplierList = TestList;
            //Test to see if the values match.
            Assert.AreEqual(AllSuppliers.SupplierList.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Create test data.
            clsSupply TestItem = new clsSupply();
            //Variable to store the primary key.
            Int32 PrimaryKey = 0;
            //Set its properties.
            TestItem.SupplierNo = 6;
            TestItem.SupplierName = "Samsung";
            TestItem.ProductName = "Galaxy Book";
            TestItem.ProductPrice = 600;
            TestItem.DateAvailable = DateTime.Now.Date;
            TestItem.IsAvailable = true;
            //Set ThisSupplier to the test data.
            AllSuppliers.ThisSupplier = TestItem;
            //Add the record.
            PrimaryKey = AllSuppliers.Add();
            //Set the primary key of the test data.
            TestItem.SupplierNo = PrimaryKey;
            //Find the record.
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //Test to see if the values match.
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the Supplier collection class.
            clsSupplyCollection AllSuppliers = new clsSupplyCollection();
            //Create test data.
            clsSupply TestItem = new clsSupply();
            //Variable to store the primary key.
            Int32 PrimaryKey = 0;
            //Set its properties.
            TestItem.SupplierNo = 6;
            TestItem.SupplierName = "Samsung";
            TestItem.ProductName = "Galaxy Book";
            TestItem.ProductPrice = 600;
            TestItem.DateAvailable = DateTime.Now.Date;
            TestItem.IsAvailable = true;
            //Set ThisSupplier to the test data.
            AllSuppliers.ThisSupplier = TestItem;
            //Add the record.
            PrimaryKey = AllSuppliers.Add();
            //Set the primary key of the test data.
            TestItem.SupplierNo = PrimaryKey;
            //Change the test data.
            TestItem.SupplierNo = 5;
            TestItem.SupplierName = "Apple";
            TestItem.ProductName = "iMac";
            TestItem.ProductPrice = 1500;
            TestItem.DateAvailable = DateTime.Now.Date;
            TestItem.IsAvailable = true;
            //Set the record to the new data.
            AllSuppliers.ThisSupplier = TestItem;
            //Update the record.
            AllSuppliers.Update();
            //Find the record.
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //Test to see if the values match.
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
    }
}
