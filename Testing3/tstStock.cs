using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //Good test data
        //Some test data to pass the method
        string ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
        string StockQuantity = "145";
        string StockArrivalDate = DateTime.Now.Date.ToString();
        string TrackingID = "6";

        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Test to see if it exist
            Assert.IsNotNull(AStock);
        }
        
        [TestMethod]
        public void ProductIDPropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            Int32 TestData = 1;
            //Assign the test data to the property
            AStock.ProductID = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            string TestData = "Luffy Case";
            //Assign the test data to the property
            AStock.ProductName = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]
        public void ProductAvailabilityPropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            Boolean TestData = true;
            //Assign the test data to the property
            AStock.ProductAvailability = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.ProductAvailability, TestData);
        }

        [TestMethod]
        public void StockQuantityPropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            Int32 TestData = 1;
            //Assign the test data to the property
            AStock.StockQuantity = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }

        [TestMethod]
        public void StockArrivalDatePropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            DateTime TestData = DateTime.Now.Date;
            //Assign the test data to the property
            AStock.StockArrivalDate = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.StockArrivalDate, TestData);
        }

        [TestMethod]
        public void TrackingIDPropertyOk()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create test data to assign to property
            Int32 TestData = 1;
            //Assign the test data to the property
            AStock.TrackingID = TestData;
            //Test to see that the test data and the property are the same
            Assert.AreEqual(AStock.TrackingID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Test to check the result
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 1;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.ProductID != 1)
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.ProductName != "Jujutsu Kaisen Iphone 11 Case")
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductAvailabilityFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.ProductAvailability != true)
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockQuantityFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.StockQuantity != 45)
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockArrivalDateFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.StockArrivalDate != Convert.ToDateTime("15/09/2022"))
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTrackingIDFound()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create boolean variable to store the result of the validation
            Boolean Found = false;
            //Create boolean variable to record if data is OK
            Boolean OK = true;
            //Create test data to use on method
            Int32 ProductID = 5;
            //Call the method
            Found = AStock.Find(ProductID);
            //Check the property
            if (AStock.TrackingID != 4)
            {
                OK = false;
            }
            //Test to check the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = ""; //Test should fail
            //Create test data to pass method
            string ProductName = "";
            //Invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "a";
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "aa";
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "";
            ProductName = ProductName.PadRight(199, 'a');
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "";
            ProductName = ProductName.PadRight(200, 'a');
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a'); 
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "";
            ProductName = ProductName.PadRight(201, 'a'); //Should Fail
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a'); //Should Fail
            //invoke the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateExtremeMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change date to 100 years before the current date
            TestDate = TestDate.AddYears(-100);
            //Converts the DateTime to a string
            string StockArrivalDate = TestDate.ToString();
            //Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateMinLessOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //Converts the DateTime to a string
            string StockArrivalDate = TestDate.ToString();
            //Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Converts the DateTime to a string
            string StockArrivalDate = TestDate.ToString();
            //Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Converts the DateTime to a string
            string StockArrivalDate = TestDate.ToString();
            //Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateExtremeMax()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data
            DateTime TestDate;
            //Set the date to todays
            TestDate = DateTime.Now.Date;
            //Change date to 100 years after the current date
            TestDate = TestDate.AddYears(100);
            //Converts the DateTime to a string
            string StockArrivalDate = TestDate.ToString();
            //Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockArrivalDateInvalidData()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Sets StockArrivalDate to a non-date value
            string StockArrivalDate = "This is not a date";
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityExtremeMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MinValue;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 0;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 1;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 2;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMax()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue - 1;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMid()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue / 2;
            //Convert Test Data to string
            string StockQuantity = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDExtremeMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MinValue;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMinMinusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 0;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMin()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 1;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = 2;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMax()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMaxMinusOne()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue - 1;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TrackingIDMid()
        {
            //Create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Create string variable to store error message
            String Error = "";
            //Create test data to pass to method
            int TestData = int.MaxValue / 2;
            //Convert Test Data to string
            string TrackingID = TestData.ToString();
            // Invokes the method
            Error = AStock.Valid(ProductName, StockQuantity, StockArrivalDate, TrackingID);
            // Tests to see if output is true
            Assert.AreEqual(Error, "");
        }

    }
}
