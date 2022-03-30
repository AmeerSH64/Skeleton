using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }


        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the we want to create.
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            decimal testData = 100;
            //assign the data to the property
            ACustomer.TotalPrice = testData;
            //test that the two values are the same
            Assert.AreEqual(ACustomer.TotalPrice, testData);
        }

        [TestMethod]
        public void Over18PropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Over18 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Over18, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //ceate an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boolean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerNo != 6)
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirth()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boollean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the date of birth
            if (ACustomer.DateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerName()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boollean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerName != "Test Customer Name")
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void TestAddress()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boollean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.Address != "Test Address")
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestTotalPrice()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boollean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.TotalPrice != 100)
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOver18()
        {
            // create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the seaarch 
            Boolean Found = false;
            //boollean variable to record if data IS OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 6;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.Over18 != true)
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }



    }
}
