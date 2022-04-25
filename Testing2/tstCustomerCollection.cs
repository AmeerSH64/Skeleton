using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 6;
            TestItem.CustomerName = "Test Customer Name";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address";
            TestItem.TotalPrice = 100;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to se that the two value are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Over18 = true;
            TestCustomer.CustomerNo = 6;
            TestCustomer.CustomerName = "Test Customer Name";
            TestCustomer.DateOfBirth = DateTime.Now.Date;
            TestCustomer.Address = "Test Address";
            TestCustomer.TotalPrice = 100;
            //asssign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to that the two value are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);


        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //creste some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the  list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 6;
            TestItem.CustomerName = "Test Customer Name";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address";
            TestItem.TotalPrice = 100;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        
    }  
    
}


