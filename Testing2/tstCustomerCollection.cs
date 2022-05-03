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
            //in this case the data needs to be a lis
            //t of objects
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


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 6;
            TestItem.CustomerName = "Test Customer Name";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address";
            TestItem.TotalPrice = 100;
            //set thisCusotmer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test dat
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);



        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 6;
            TestItem.CustomerName = "Test Customer Name";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address";
            TestItem.TotalPrice = 100;
            //set thisCusotmer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.Over18 = false;
            TestItem.CustomerNo = 3;
            TestItem.CustomerName = "Test Customer Name two";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address two";
            TestItem.TotalPrice = 200;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //Update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Over18 = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Test Customer Name";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Address = "Test Address";
            TestItem.TotalPrice = 100;
            //set this customer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //Finf the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //Test to see that the record was not fpund
            Assert.IsFalse(Found);


        }

        [TestMethod]
        public void ReportByAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filter data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByAddressNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply an address that does ot exist
            FilteredCustomers.ReportByAddress("XXX XXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByAddressTestDataFound()
        {
            //create an instance of the filter data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store ourcome
            Boolean OK = true;
            //apply an address that does not exist
            FilteredCustomers.ReportByAddress("yyyyy");
            //check that the correct number of record are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomers.CustomerList[0].CustomerNo != 36)
                {
                    OK = false;

                }
                //check that the first recors is ID 37
                if (FilteredCustomers.CustomerList[1].CustomerNo != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            //test to see that there are no record
            Assert.IsTrue(OK);
        }
        
    }  
    
}


