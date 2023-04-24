using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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

    }
}
