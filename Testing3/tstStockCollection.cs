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
            // Tests to see if both values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


    }
}
