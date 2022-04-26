using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ConfirmOrder = true;
            TestItem.OrderNumber = 1;
            TestItem.TrackingNumber = 317691783;
            TestItem.ProductName = "HP Pavilion Power";
            TestItem.Price = 500;
            TestItem.CustomerName = "Akash Vinodrai";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the tyest list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);

        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.ConfirmOrder = true;
            TestOrder.OrderNumber = 1;
            TestOrder.TrackingNumber = 317691783;
            TestOrder.ProductName = "HP Pavilion Power";
            TestOrder.Price = 500;
            TestOrder.CustomerName = "Akash Vinodrai";
            TestOrder.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two value are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            TestItem.ConfirmOrder = true;
            TestItem.OrderNumber = 1;
            TestItem.TrackingNumber = 317691783;
            TestItem.ProductName = "HP Pavilion Power";
            TestItem.Price = 500;
            TestItem.CustomerName = "Akash Vinodrai";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ConfirmOrder = true;
            TestItem.OrderNumber = 1;
            TestItem.TrackingNumber = 317691783;
            TestItem.ProductName = "HP Pavilion Power";
            TestItem.Price = 500;
            TestItem.CustomerName = "Akash Vinodrai";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ConfirmOrder = true;
            TestItem.OrderNumber = 1;
            TestItem.TrackingNumber = 317691783;
            TestItem.ProductName = "HP Pavilion Power";
            TestItem.Price = 500;
            TestItem.CustomerName = "Akash Vinodrai";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisAddress to the test date
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;
            //modify the test data
            TestItem.ConfirmOrder = false;
            TestItem.OrderNumber = 2;
            TestItem.TrackingNumber = 367265378;
            TestItem.ProductName = "HP Envy";
            TestItem.Price = 699;
            TestItem.CustomerName = "Ismael Akhter";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want ton create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ConfirmOrder = true;
            TestItem.OrderNumber = 1;
            TestItem.TrackingNumber = 317691783;
            TestItem.ProductName = "HP Pavilion Power";
            TestItem.Price = 500;
            TestItem.CustomerName = "Akash Vinodrai";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //all the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderNumber = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameOK()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a bank string (should return all records)
            FilteredOrders.ReportByProductName("");
            //test to see that the two values are the samr
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a product name that doesn't exist
            FilteredOrders.ReportByProductName("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Product Name that doesn't exist
            FilteredOrders.ReportByProductName("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
            //check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredOrders.OrderList[0].OrderNumber != 36)
                {
                    OK = false;
                }
                //check that the first record in ID 37
                if (FilteredOrders.OrderList[1].OrderNumber != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that thee are no records
            Assert.IsTrue(OK);
        }
    }
}