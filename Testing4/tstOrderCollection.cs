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
            AllOrders.ThisAddress = TestItem;
            Assert.AreEqual(AllOrders.ThisAddress, TestItem);
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






    }
}
