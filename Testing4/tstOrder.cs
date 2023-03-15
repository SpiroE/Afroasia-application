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
        public void FulfilledValid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FulfilledMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = false;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FulfilledMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            Boolean TestData = true;
            //create error message
            string Error = "";
            Error = AnOrder.FulfilledValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedOK()
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
        public void DateAddedMinExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(-100);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(-1).AddDays(-1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(-1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddDays(+1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(+1).AddDays(-1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(+1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(+1).AddDays(+1);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddMonths(+6);
            string Error = "";
            Error = AnOrder.DateAddedValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesOK()
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
        public void NoOfCasesMinExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = -1000000;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 0;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 2;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue - 1;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NoOfCasesMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue;
            //create error message
            string Error = "";
            Error = AnOrder.NoOfCasesValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDOK()
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

        [TestMethod]
        public void ProductIDMinExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = -1000000;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 0;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlussOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 2;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue - 1;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue;
            //create error message
            string Error = "";
            Error = AnOrder.ProductIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressOK()
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

        [TestMethod]
        public void AddressValid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "17 Arminia Street, Leicester, LE4 6ER";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "1";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "17";
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(99, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(100, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(101, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(50, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            string TestData = "";
            TestData = TestData.PadLeft(5000, '*');
            //create error message
            string Error = "";
            Error = AnOrder.AddressValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDOK()
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

        [TestMethod]
        public void OrderNoOK()
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
