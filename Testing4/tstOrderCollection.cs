using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to asign to the property
            //in this case the needs to be a lsit of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerID = 1;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 1;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            //add items to the list
            TestList.Add(TestItem);
            //assign data to the property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerID = 1;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 1;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            //assign data to the property
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to asign to the property
            //in this case the needs to be a lsit of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerID = 1;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 1;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            //add items to the list
            TestList.Add(TestItem);
            //assign data to the property
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerID = 4;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 4;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            //add items to the list
            TestItem.OrderNo = PrimaryKey;
            //assign data to the property
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 4;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 4;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            //add items to the list
            TestItem.OrderNo = PrimaryKey;
            TestItem.CustomerID = 4;
            TestItem.Address = "17 Noway Lane, NW15 6LN";
            TestItem.ProductID = 2;
            TestItem.NoOfCases = 8;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = false;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();

            //assign data to the property
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for the list
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderNo = 1;
            TestItem.CustomerID = 4;
            TestItem.Address = "15 Noway Lane, NW15 6LN";
            TestItem.ProductID = 4;
            TestItem.NoOfCases = 10;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Fulfilled = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            //add items to the list
            TestItem.OrderNo = PrimaryKey;
            //assign data to the property
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        // Count the number of true and then change the AreEqual value +1.
        //[TestMethod]
        //public void ReportByFulfilledTrueFound()
        //{
            //clsOrderCollection AllOrders = new clsOrderCollection();
            //clsOrderCollection FilteredOrders = new clsOrderCollection();
            //FilteredOrders.ReportByFulfilled(true);
            //remeber to add 1 every run as the add/update function is still running
            //Assert.AreEqual(10, FilteredOrders.Count);
        //}


    }
}
