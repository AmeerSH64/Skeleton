using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerName = "Test Name";
        string Address = "Test Address";
        string DateOfBirth = DateTime.Now.Date.ToString();


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
            Int32 CustomerNo = 6;
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store my error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test dta to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = Acustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a"; //this should be ok
            //invoke the method
            Error = Acustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data t pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


            
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 200 year
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(200);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the dateofbirth to a  ot date value
            string DateOfBirth = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerName,DateOfBirth,Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, DateOfBirth, Address);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
