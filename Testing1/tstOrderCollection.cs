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
    }
}