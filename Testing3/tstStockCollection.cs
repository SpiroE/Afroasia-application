using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Test to see if it exist
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Assigns test data to the property
            List<clsStock> TestList = new List<clsStock>();
            //Create test data to add to the list
            clsStock TestItem = new clsStock();
            //Setting the properties of each item
            TestItem.ProductID = 1;
            TestItem.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = true;
            TestItem.StockQuantity = 80;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 5;
            //Add the test items to the test list
            TestList.Add(TestItem);
            //Assign test data to the property
            AllStock.StockList = TestList;
            // Tests to see if both values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create test data to add to assign to property
            clsStock TestStock = new clsStock();
            //Setting the properties of each item
            TestStock.ProductID = 1;
            TestStock.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestStock.ProductAvailability = true;
            TestStock.StockQuantity = 80;
            TestStock.StockArrivalDate = DateTime.Now.Date;
            TestStock.TrackingID = 5;
            //Assign test data to the property
            AllStock.ThisStock = TestStock;
            // Tests to see if both values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Assigns test data to the property
            List<clsStock> TestList = new List<clsStock>();
            //Create test data to add to the list
            clsStock TestItem = new clsStock();
            //Setting the properties of each item
            TestItem.ProductID = 1;
            TestItem.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = true;
            TestItem.StockQuantity = 80;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 5;
            //Add the test items to the test list
            TestList.Add(TestItem);
            //Assign test data to the property
            AllStock.StockList = TestList;
            //Tests to see if both values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create item to test data 
            clsStock TestItem = new clsStock();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.ProductID = 1;
            TestItem.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = true;
            TestItem.StockQuantity = 80;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 5;
            //Setting ThisCustomer to test data
            AllStock.ThisStock = TestItem;
            //Adding the record
            PrimaryKey = AllStock.Add();
            //Setting the Primary Key of the test data
            TestItem.ProductID = PrimaryKey;
            //Find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //Tests to see if both values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create item to test data 
            clsStock TestItem = new clsStock();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = true;
            TestItem.StockQuantity = 80;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 5;
            //Setting ThisStock to test data
            AllStock.ThisStock = TestItem;
            //Adding the record
            PrimaryKey = AllStock.Add();
            //Setting the Primary Key of the test data
            TestItem.ProductID = PrimaryKey;
            //Modifying the test data properties
            TestItem.ProductName = "Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = false;
            TestItem.StockQuantity = 90;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 8;
            //Setting the record based on the modified test data
            AllStock.ThisStock = TestItem;
            //Update the record
            AllStock.Update();
            //Find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //Tests to see if ThisStock matches specified test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create item to test data 
            clsStock TestItem = new clsStock();
            //Variable to store Primary Key
            Int32 PrimaryKey = 0;
            //Setting the properties of each item
            TestItem.ProductName = "Jujutsu Kaisen: Yuji Itadori Iphone 11 Case";
            TestItem.ProductAvailability = true;
            TestItem.StockQuantity = 80;
            TestItem.StockArrivalDate = DateTime.Now.Date;
            TestItem.TrackingID = 5;
            //Setting ThisStock to test data
            AllStock.ThisStock = TestItem;
            //Adding the record
            PrimaryKey = AllStock.Add();
            //Setting the Primary Key of the test data
            TestItem.ProductID = PrimaryKey;
            //Find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //Delete the record
            AllStock.Delete();
            //Now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //Tests to see that the record wasn't found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //Create an instance of the filtered data 
            clsStockCollection FilteredStock = new clsStockCollection();
            //Apply a blank string
            FilteredStock.ReportByProductName("");
            //Tests to see that the record wasn't found
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //Create an instance of the filtered data 
            clsStockCollection FilteredStock = new clsStockCollection();
            //Apply a product name that don't exist 
            FilteredStock.ReportByProductName("XXX XXX");
            //Tests to see that there are no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //Create an instance of the filtered data 
            clsStockCollection FilteredStock = new clsStockCollection();
            //Variable to store outcome
            Boolean OK = true;
            //Apply a product name that don't exist 
            FilteredStock.ReportByProductName("ZZZ ZZZ");
            //Check if the currect number of records are found
            if (FilteredStock.Count == 2)
            {
                //Check that the first record ID is 8
                if (FilteredStock.StockList[0].ProductID != 8)
                {
                    OK = false;
                }
                //Check that the first record ID is 9
                if (FilteredStock.StockList[1].ProductID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //Tests to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
