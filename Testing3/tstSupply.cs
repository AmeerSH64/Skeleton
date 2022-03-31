using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupply
    {
        //Good test data.
        //Create test data to pass the method.
        string SupplierName = "Apple";
        string ProductName = "MacBook";
        string ProductPrice = "1000";
        string DateAvailable = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the suplier class.
            clsSupply Supplier = new clsSupply();
            //Test to see that it exists.
            Assert.IsNotNull(Supplier);
        }

        [TestMethod]
        public void SupplierNoPropertyOK()
        {
            //Create an instance of the supplier class.
            clsSupply Supplier = new clsSupply();
            //Create test data.
            Int32 testData = 2;
            //Assign the data to the property.
            Supplier.SupplierNo = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.SupplierNo, testData);
        }

        [TestMethod]
        public void IsAvaiablePropertyOK()
        {
            //Create an instance of the suppler class.
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
            Int32 testData = 100;
            //Assign the data to the property.
            Supplier.ProductPrice = testData;
            //Test that the values are the same.
            Assert.AreEqual(Supplier.ProductPrice, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            //Test to see if the result is true.
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierNoFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Boolean to show whether data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.SupplierNo != 2)
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Boolean to show whether data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.SupplierName != "Microsoft")
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAvailableFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Boolean to show whether data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.IsAvailable != true)
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }
      
        [TestMethod]
        public void TestProductNameFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create Boolean to show results.
            Boolean Found = false;
            //Create boolean to show data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.ProductName != "Surface Laptop")
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Boolean to show whether data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.ProductPrice != 900)
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAvailableFound()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Boolean value for the validation results.
            Boolean Found = false;
            //Boolean to show whether data is OK.
            Boolean OK = true;
            //Create test data.
            Int32 SupplierNo = 2;
            //Invoke the method.
            Found = Supplier.Find(SupplierNo);
            if (Supplier.DateAvailable != Convert.ToDateTime("10/02/2022"))
            {
                OK = false;
            }
            //Test to see if the result is true.
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "a";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "aa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAvailableExtremeMin()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Assign today's date to a variable.
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the date to 100 years ago.
            TestDate = TestDate.AddYears(-100);
            //Convert it to a string variable.
            String DateAvailable = Convert.ToString(TestDate);
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAvailableMinLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Assign today's date to a variable.
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the date to 1 day ago.
            TestDate = TestDate.AddDays(-1);
            //Convert it to a string variable.
            String DateAvailable = Convert.ToString(TestDate);
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAvailableMin()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Assign today's date to a variable.
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Convert it to a string variable.
            String DateAvailable = Convert.ToString(TestDate);
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAvailableMinPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Assign today's date to a variable.
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the date to tomorrow.
            TestDate = TestDate.AddDays(1);
            //Convert it to a string variable.
            String DateAvailable = Convert.ToString(TestDate);
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAvailableExtremeMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Assign today's date to a variable.
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the date to 100 years later.
            TestDate = TestDate.AddYears(100);
            //Convert it to a string variable.
            String DateAvailable = Convert.ToString(TestDate);
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void InvalidDateAvailable()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create an invalid date variable.
            String DateAvailable = "Not a date.";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "a";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "aa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductName = "";
            SupplierName = SupplierName.PadRight(500, 'a');
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "0";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMin()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "1";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "2";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "9998";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMax()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "9999";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "10000";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void ProductPriceMid()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "5000";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void InvalidProductPrice()
        {
            //Create an instance of the Supplier class.
            clsSupply Supplier = new clsSupply();
            //Create a string to store the error message.
            String error = "";
            //Create test data.
            String ProductPrice = "Not a number";
            //Invoke the method.
            error = Supplier.Valid(SupplierName, ProductName, ProductPrice, DateAvailable);
            //Test to see if an error occurs.
            Assert.AreNotEqual(error, "");
        }
    }
}
