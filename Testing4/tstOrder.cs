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
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void OrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if(AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Address != "15 Sumerway Street, LE2 8AH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ProductIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.ProductID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void NoOfCasesFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.NoOfCases != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateAddedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.DateAdded != Convert.ToDateTime("14/04/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FulfilledFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            int OrderNo = 1;
            Found = AnOrder.Find(OrderNo);
            if (AnOrder.Fulfilled != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
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
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = TestData.ToString();
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddDays(-1);
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = TestData.ToString();
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = TestData.ToString();
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = TestData.ToString();
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            DateTime TestData = DateTime.Now.Date.AddYears(+100);
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = TestData.ToString();
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = "1";
            string NoOfCasesTestData = TestData.ToString();
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = "17 Camdem Road, CA15 1TR";
            string ProductIDTestData = TestData.ToString();
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = "1";
            string AddressTestData = TestData;
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
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
        public void CustomerIDMinExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = -1000000;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 0;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlussOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 2;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue - 1;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue;
            //create error message
            DateTime DateToday = DateTime.Now.Date;
            string CustomerIDTestData = TestData.ToString();
            string AddressTestData = "54 Waterloo Loo, L00 100";
            string ProductIDTestData = "10";
            string NoOfCasesTestData = "10";
            string DateAddedTestData = Convert.ToString(DateToday);
            string Error = "";
            Error = AnOrder.Valid(CustomerIDTestData, AddressTestData, ProductIDTestData, NoOfCasesTestData, DateAddedTestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
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

        [TestMethod]
        public void OrderIDMinExtreme()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = -1000000;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 0;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 1;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlussOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = 2;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue - 1;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create some test data
            int TestData = int.MaxValue;
            //create error message
            string Error = "";
            Error = AnOrder.OrderIDValid(TestData);
            // test to see if the two values are the same
            Assert.AreEqual(Error, "");
        }

    }


}
