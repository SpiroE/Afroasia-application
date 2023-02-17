using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;


namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the new Class specified below
            clsOrder AnOrder = new clsOrder();
            // Tests to check existence
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void FulfilledOrderOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            // assign the data to the property
            AnOrder.Fulfilled = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.Fulfilled, TestData);
        }
        
        [TestMethod]
        public void DateAddedOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            AnOrder.DateAdded = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void NoOfCasesOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.NoOfCases = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.NoOfCases, TestData);
        }

        [TestMethod]
        public void ProductIDOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.ProductID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }

        public void AddressOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "15 Sowe Valley, Leicester, LE1 2NF";
            // assign the data to the property
            AnOrder.Address = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        public void CustomerIDOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.CustomerID = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        public void OrderNoOrder()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            AnOrder.OrderNo = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
    }
   

}
